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
                        <span class="headline">{{ formTitle }}</span>
                    </v-card-title>
                    <v-card-text>
                        <v-container>
                            <v-row>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.ID" label="ID сотрудника"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.name" label="ФИО"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.passport" label="Паспортные данные"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.salary" label="Зарплата"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.place" label="Должность"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.SNILS" label="СНИЛС"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.INN" label="ИНН"></v-text-field>
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
                {text: 'Паспортные данные', value: 'passport'},
                {text: 'Зарплата', value: 'salary'},
                {text: 'Должность', value: 'place'},
                {text: 'СНИЛС', value: 'SNILS'},
                {text: 'ИНН', value: 'INN'},
                {text: 'Действия', value: 'action', sortable: false},
            ],
            employees: [],
            editedIndex: -1,
            editedItem: {
                name: '',
                passport: '',
                salary: 0,
                place: '',
                SNILS: '',
                INN: '',
            },
            defaultItem: {
                name: '',
                passport: '',
                salary: 0,
                place: '',
                SNILS: '',
                INN: '',
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
                axios.get('http://localhost:5000/getInfo?table=' + window.location.href.split('/')[4])
                    .then(function (res) {
                        rw.bills = res.data;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    })
            },

            editItem(item) {
                this.editedIndex = this.employees.indexOf(item);
                this.editedItem = Object.assign({}, item);
                this.dialog = true;
            },

            deleteItem(item) {
                const index = this.employees.indexOf(item);
                confirm('Удалить элемент') && this.employees.splice(index, 1);
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
                    Object.assign(this.employees[this.editedIndex], this.editedItem);
                } else {
                    this.employees.push(this.editedItem);
                }
                this.close();
            },
        },
    }
</script>

<style scoped>

</style>
