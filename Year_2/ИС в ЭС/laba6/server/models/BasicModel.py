from contextlib import closing
import psycopg2


class SQLModel:

    @classmethod
    def normalize_cols(cls, cols):
        new_cols = ''
        for x in cols:
            new_cols += str(x) + ', '
        new_cols = new_cols[0:-2]
        return new_cols

    @staticmethod
    def insert(table, cols, values):
        """
            Inserts the data into the database
            args:
                values: the values to be inserted into the database
        """
        with closing(psycopg2.connect(database='crm', user='postgres', password='MOORMOOR',
                                      host='127.0.0.1', port='5432')) as conn:
            with conn.cursor() as cursor:
                sql_insert_query = """INSERT INTO {}({}) VALUES {} """.format(table, cols, values)
                print(sql_insert_query)
                cursor.execute(sql_insert_query)
                conn.commit()

    @classmethod
    def get_by_attrs(cls, cols, table, attr_cols, attr_values, group_by=None, order_by=None):
        new_cols = cls.normalize_cols(cols)
        with closing(psycopg2.connect(database='crm', user='postgres', password='MOORMOOR',
                                      host='127.0.0.1', port='5432')) as conn:
            with conn.cursor() as cursor:
                if group_by is None and order_by is None:
                    sql_select_query = """SELECT {} FROM {} WHERE {}='{}' """.format(new_cols, table, attr_cols, attr_values)
                    cursor.execute(sql_select_query)
                    value = cursor.fetchall()
                    return value
                if group_by is not None and order_by is None:
                    sql_select_query = """SELECT {} FROM {} WHERE {}='{}' GROUP BY {}""".format(new_cols, table, attr_cols, attr_values, group_by)
                    cursor.execute(sql_select_query)
                    value = cursor.fetchall()
                    return value
                if group_by is None and order_by is not None:
                    sql_select_query = ("""SELECT {} FROM {} WHERE {} = '{}' ORDER BY {}""").format(new_cols, table, attr_cols, attr_values, order_by)
                    cursor.execute(sql_select_query)
                    value = cursor.fetchall()
                    return value
                else:
                    sql_select_query = """SELECT {} FROM {} WHERE {}='{}' GROUP BY {} ORDER BY {}""".format(
                        new_cols, table, attr_cols, attr_values, group_by, order_by)
                    cursor.execute(sql_select_query)
                    value = cursor.fectchall()
                    return value
    @classmethod
    def update_by_attrs(cls, table, columns, values, attr_cols, attr_values):
        with closing(psycopg2.connect(database='crm', user='postgres', password='MOORMOOR',
                                      host='127.0.0.1', port='5432')) as conn:
            with conn.cursor() as cursor:
                sql_update_query = """UPDATE {} SET ({})={} WHERE {}={}""".format(table, columns, values, attr_cols, attr_values)
                print(sql_update_query)
                cursor.execute(sql_update_query)
                conn.commit()

    @staticmethod
    def delete_by_attrs(table, attr_cols, attr_values):
        with closing(psycopg2.connect(database='crm', user='postgres', password='MOORMOOR',
                                      host='127.0.0.1', port='5432')) as conn:
            with conn.cursor() as cursor:
                sql_delete_query = """DELETE FROM {} where {}='{}'""".format(table, attr_cols, attr_values)
                print(sql_delete_query)
                cursor.execute(sql_delete_query)
                conn.commit()


class BasicModel(SQLModel):

    def __getattr__(self, item):
        if item in self._FIELDS_MAPPING.keys():
            return self.__dict__[item]
        raise AttributeError

    def __setattr__(self, key, value):
        if key in self._FIELDS_MAPPING.keys():
            print(value)
            self.__dict__[key] = value
        else:
            raise AttributeError

    def __init__(self):
        raise AbstractClassError

    def print_info(self):
        """
         prints all the attributes of the object
        """
        for value in self._FIELDS_MAPPING:
            print(str(value) + " = " + str(self.__dict__[value]))