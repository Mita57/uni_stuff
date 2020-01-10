<template>
    <v-data-table :headers="headers" :items="employees" sort-by="ID" class="elevation-1">
        <template v-slot:top>
            <h1 class="ml-3">Сотрудники</h1>
            <v-dialog v-model="dialog" max-width="500px">
                <template v-slot:activator="{ on }">
                    <v-btn color="primary" dark class="mb-2 ml-2" v-on="on" tile>Добавить элемент</v-btn>
                </template>
                <v-card>
                    <v-card-title>
                        <span class="headline">Сотрудник</span>
                    </v-card-title>
                    <v-card-text>
                        <v-container>
                            <v-row>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.ID" id="id" disabled label="ID сотрудника"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.name" id="name" label="ФИО"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.position" id="position"
                                                  label="Должность"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.salary" id="salary"
                                                  label="Зарплата"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.passport" id="passport"
                                                  label="Паспорт"></v-text-field>
                                </v-col>
                            </v-row>
                        </v-container>
                    </v-card-text>

                    <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn color="blue darken-1" text @click="close">Отменить</v-btn>
                        <v-btn color="blue darken-1" text @click="save">Сохранить</v-btn>
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
        name: "BillsInfo",
        data: () => ({
            dialog: false,
            headers: [
                {text: 'ID сотрудника', value: 'ID'},
                {text: 'ФИО', value: 'name'},
                {text: 'Должность', value: 'position'},
                {text: 'Зарплата', value: 'salary'},
                {text: 'Паспорт', value: 'passport'},
                {text: 'Действия', value: 'action', sortable: false},
            ],
            employees: [],
            editedIndex: -1,
            editedItem: {
                ID: 'ID',
                name: '',
                passport: '',
                salary: 0,
                position: '',
            },
            defaultItem: {
                ID: 'ID',
                name: '',
                passport: '',
                salary: 0,
                position: '',
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
                axios.get('http://localhost:5000/getInfo?table=' + window.location.href.split('/')[3])
                    .then(function (res) {
                        let goodBills = [];
                        for (let i = 0; i < res.data.length; i++) {
                            let elem = {
                                ID: res.data[i][0],
                                name: res.data[i][1],
                                position: res.data[i][2],
                                salary: res.data[i][3],
                                passport: res.data[i][4]
                            };
                            goodBills.push(elem);
                        }
                        rw.employees = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    });

            },

            editItem(item) {
                this.editedIndex = this.employees.indexOf(item);
                this.editedItem = Object.assign({}, item);
                this.dialog = true;
            },

            deleteItem(item) {
                const rw = this;
                const index = this.dealers.indexOf(item);
                let result = confirm("Удалить элемент " + (this.employees[index].ID) + '?');
                if (result) {
                    axios({
                        method: 'post',
                        url: 'http://localhost:5000/removeElement',
                        data: {
                            table: 'employees',
                            id: rw.employees[index].ID
                        },
                    }).then(function (response) {
                        location.reload();
                    })
                        .catch(function (response) {
                            //handle error
                            console.log(response);
                        })
                }
            },

            close() {
                this.dialog = false;
                setTimeout(() => {
                    this.editedItem = Object.assign({}, this.defaultItem);
                    this.editedIndex = -1;
                }, 300)
            },

            save() {
                let nameCheck = false;
                let positionCheck = false;
                let salaryCheck = false;
                let passportCheck = false;
                if (document.getElementById('name').value) {
                    nameCheck = true;
                }
                if (document.getElementById('position').value) {
                    positionCheck = true;
                }
                if (document.getElementById('passport').value) {
                    passportCheck = true;
                }
                if (!isNaN(document.getElementById('salary').value)) {
                    salaryCheck = true;
                }


                if (nameCheck && positionCheck && salaryCheck && passportCheck) {
                    if (document.getElementById('id').value == 'ID') {
                        addItem();
                    } else {
                        updateItem();
                    }
                }


                function addItem() {
                    axios({
                        method: 'post',
                        url: 'http://localhost:5000/addElement',
                        data: {
                            table: 'employees',
                            cols: 'name, position, salary, passport',
                            values: "('" + document.getElementById('name').value + "', '"
                                + document.getElementById('position').value + "','" + document.getElementById('salary').value +
                                "', '" + document.getElementById('passport').value + "')"
                        },
                    }).then(function (response) {
                        location.reload();
                    })
                        .catch(function (response) {
                            //handle error
                            console.log(response);
                        })
                }


                function updateItem() {
                    axios({
                        method: 'post',
                        url: 'http://localhost:5000/updateElement',
                        data: {
                            table: 'employees',
                            cols: 'name, position, salary, passport',
                            id: document.getElementById('id').value,
                            values: "('" + document.getElementById('name').value + "', '"
                                + document.getElementById('position').value + "','" + document.getElementById('salary').value +
                                "', '" + document.getElementById('passport').value + "')"
                        },
                    }).then(function (response) {
                        location.reload();
                    })
                        .catch(function (response) {
                            //handle error
                            console.log(response);
                        })
                }

            },


        },
    }
</script>

<style scoped>

</style>
