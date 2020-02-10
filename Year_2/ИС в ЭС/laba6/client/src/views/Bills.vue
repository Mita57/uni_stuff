<template>
    <v-data-table :headers="headers" :items="bills" sort-by="ID" class="elevation-1">
        <template v-slot:top>
            <h1 class="ml-3">Чеки</h1>
            <v-dialog v-model="dialog" max-width="500px">
                <template v-slot:activator="{ on }">
                    <v-btn color="primary" dark class="mb-2 ml-2" v-on="on" tile>Добавить элемент</v-btn>
                </template>
                <v-card>
                    <v-card-title>
                        <span class="headline">Чек</span>
                    </v-card-title>
                    <v-card-text>
                        <v-container>
                            <v-row>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.ID" disabled label="ID"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.price" disabled label="Стоимость"></v-text-field>
                                </v-col>
                                <v-col class="d-flex" cols="12" sm="6">
                                    <v-select :items="employees" label="Кассир" dense outlined></v-select>
                                </v-col>
                                <v-col class="d-flex" cols="12" sm="6">
                                    <v-select :items="products" id="sas" label="Товары" dense outlined></v-select>
                                </v-col>
                                <v-btn color="blue darken-1" text @click="addToBill()">Добавить в чек</v-btn>
                                <v-col class="d-flex">
                                    <v-data-table :headers="checkHeaders" :items='checkItems' :items-per-page="5"
                                                  class="elevation-1"></v-data-table>
                                </v-col>
                            </v-row>
                        </v-container>
                    </v-card-text>

                    <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn color="blue darken-1" text @click="close()">Отменить</v-btn>
                        <v-btn color="blue darken-1" text @click="save()">Сохранить</v-btn>
                    </v-card-actions>
                </v-card>
            </v-dialog>
        </template>
        <template v-slot:item.action="{ item }">
            <v-icon small @click="editItem(item)">mdi-pencil-outline</v-icon>
            <v-icon class="ml-5" small @click="deleteItem(item)">mdi-delete</v-icon>
        </template>
        <template v-slot:no-data>
            <v-btn color="primary" @click="initialize">Перезагрузить</v-btn>
        </template>
    </v-data-table>
</template>

<script>
    import axios from 'axios';

    export default {
        name: "Bills",
        data: () => ({
            dialog: false,
            headers: [
                {text: 'ID', align: 'left', value: 'ID'},
                {text: 'Стоимость', value: 'price'},
                {text: 'Сотрудник', value: 'employee'},
                {text: 'Товары', value: 'list'},
                {text: 'Действия', value: 'action', sortable: false},
            ],
            checkHeaders: [
                {text: 'ID', align: 'left', value: 'ID'},
                {text: 'Стоимость', value: 'price'},
                {text: 'Название', value: 'name'},
            ],
            checkItems: [],
            bills: [],
            employees: [],
            products: [],
            productsBills: [],
            editedIndex: -1,
            editedItem: {
                ID: '',
                employee_id: 0,
                price: 0,
            },
            defaultItem: {
                ID: '',
                employee_id: 0,
                price: 0,
            },
        }),

        computed: {
            formTitle() {
                return this.editedIndex === -1 ? 'New Item' : 'Edit Item'
            },
        },

        watch: {
            dialog(val) {
                val || this.close()
            },
        },

        created() {
            this.initialize()
        },

        methods: {
            initialize() {
                const rw = this;
                axios.get('http://localhost:5000/getInfo?table=employees')
                    .then(function (res) {
                        let goodBills = [];
                        for (let i = 0; i < res.data.length; i++) {
                            let elem = res.data[i][0] + ":" + res.data[i][1];
                            goodBills.push(elem);
                        }
                        rw.employees = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    });
                axios.get('http://localhost:5000/getInfo?table=products')
                    .then(function (res) {
                        let goodBills = [];
                        for (let i = 0; i < res.data.length; i++) {
                            let elem = res.data[i][0] + ":" + res.data[i][2] + ":" + res.data[i][1];
                            goodBills.push(elem);
                        }
                        rw.products = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    });

                axios.get('http://localhost:5000/getInfo?table=products_bills')
                    .then(function (res) {
                        let goodBills = [];
                        for (let i = 0; i < res.data.length; i++) {
                            let elem = {
                                product: res.data[i][0],
                                bill: res.data[i][1],
                            };
                            goodBills.push(elem);
                        }
                        rw.productsBills = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    });

                axios.get('http://localhost:5000/getInfo?table=' + window.location.href.split('/')[3])
                    .then(function (res) {
                        let goodBills = [];
                        for (let i = 0; i < res.data.length; i++) {
                            let cock = '';
                            for (let j = 0; j < rw.productsBills.length; j++) {
                                if (rw.productsBills[i].bill == res.data[i][0]) {
                                    cock += rw.productsBills[j].product + ' ';
                                }
                            }
                            let name = '';
                            for (let j = 0; j < rw.employees.length; j++) {
                                if (res.data[i][2] == rw.employees[i].split(":")[0]) {
                                    name = rw.employees[i].split(':')[1];
                                }
                            }
                            let elem = {
                                ID: res.data[i][0],
                                employee_id: res.data[i][2],
                                price: res.data[i][1],
                                list: cock,
                                employee: name
                            };

                            goodBills.push(elem);
                        }
                        rw.bills = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    })

            },

            editItem(item) {
                this.editedIndex = this.bills.indexOf(item);
                this.editedItem = Object.assign({}, item);
                this.dialog = true;
            },

            deleteItem(item) {
                const index = this.bills.indexOf(item);
                confirm('Удалить элемент') && this.bills.splice(index, 1);
            },

            close() {
                this.dialog = false;
                setTimeout(() => {
                    this.editedItem = Object.assign({}, this.defaultItem);
                    this.editedIndex = -1;
                }, 300)
            },

            save() {
                if (this.editedIndex > -1) {
                    Object.assign(this.bills[this.editedIndex], this.editedItem);
                } else {
                    this.bills.push(this.editedItem);
                }
                this.close();
                this.checkItems.clean();
            },
            addToBill() {
                let item = document.getElementById('sas').innerHTML;
                console.log(item);
                let id = item.split(':')[0];
                let name = item.split(':')[1];
                let price = item.split(':')[2];
                let kek = {
                    ID: id,
                    name: name,
                    price: price
                };
                this.checkItems.push(kek);
            }
        }
    }
</script>

<style scoped>

</style>
