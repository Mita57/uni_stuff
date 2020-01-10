from flask import Flask, jsonify, request, Response
from flask_cors import CORS
from models.BasicModel import SQLModel

app = Flask(__name__)
CORS(app)


@app.route('/login', methods=['POST'])
def login():
    """
    Gets the data from the login form and authorizes the input

    Returns: JSON with auth result info
    """
    data = request.get_json()
    try:
        id = data.get('id')
        password = data.get('password')
        user = SQLModel.get_by_attrs('*', 'users', 'id', id)
        user_pw = user[0][1]
        user_id = user[0][0]
        if password == user_pw:
            return jsonify(result=user_id)
        else:
            return jsonify(result='fail')
    except:
        return jsonify(result='fail')


@app.route("/getInfo")
def get_info():
    table = request.args.get('table')
    print(table)
    response = SQLModel.get_by_attrs('*', table, 1, 1)
    return jsonify(response)


@app.route('/addElement', methods=['POST'])
def add_element():
    data = request.get_json()
    table = data.get('table')
    values = data.get('values')
    cols = data.get('cols')
    SQLModel.insert(table, cols, values)
    return 'sas'


@app.route('/removeElement', methods=['POST'])
def remove_element():
    data = request.get_json()
    table = data.get('table')
    id = data.get('id')
    print(data)
    SQLModel.delete_by_attrs(table, 'id', id)
    return 'sas'


@app.route('/updateElement', methods=['POST'])
def update_element():
    data = request.get_json()
    table = data.get('table')
    attr_values = data.get('id')
    cols = data.get('cols')
    values = data.get('values')
    SQLModel.update_by_attrs(table, cols, values, 'id', attr_values)
    return 'sas'


if __name__ == '__main__':
    app.run(debug=True)
