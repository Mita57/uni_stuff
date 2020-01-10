<template>
    <v-data-table :headers="headers" :items="dealers" sort-by="ID" class="elevation-1">
        <template v-slot:top>
            <h1 class="ml-3">Поставщики</h1>
            <v-dialog v-model="dialog" max-width="500px">
                <template v-slot:activator="{ on }">
                    <v-btn color="primary" dark class="mb-2 ml-2" v-on="on" tile>Добавить элемент</v-btn>
                </template>
                <v-card>
                    <v-card-title>
                        <span class="headline">Поставщик</span>
                    </v-card-title>
                    <v-card-text>
                        <v-container>
                            <v-row>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.ID" disabled id="id"
                                                  label="ID"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.product" id="prod"
                                                  label="Товар"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.name" id="name" label="Название"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.price" id="price"
                                                  label="Оптовая цена"></v-text-field>
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
        name: "Dealers",
        data: () => ({
            dialog: false,
            headers: [
                {text: 'ID', align: 'left', value: 'ID'},
                {text: 'Товар', value: 'product'},
                {text: 'Оптовая цена', value: 'price'},
                {text: 'Название', value: 'name'},
                {text: 'Действия', value: 'action', sortable: false},
            ],
            dealers: [],
            editedIndex: -1,
            editedItem: {
                product: '',
                name: '',
                price: 0,
                ID: 'ID',
            },
            defaultItem: {
                product: '',
                name: '',
                price: 0,
                ID: 'ID'
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
                                product: res.data[i][2],
                                price: res.data[i][3]
                            };
                            goodBills.push(elem);
                        }
                        rw.dealers = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    })
            },

            editItem(item) {
                this.editedIndex = this.dealers.indexOf(item);
                this.editedItem = Object.assign({}, item);
                this.dialog = true;
            },

            deleteItem(item) {
                const rw = this;
                const index = this.dealers.indexOf(item);
                let result = confirm("Удалить элемент " + (this.dealers[index].ID) + '?');
                if (result) {
                    axios({
                        method: 'post',
                        url: 'http://localhost:5000/removeElement',
                        data: {
                            table: 'dealers',
                            id: rw.dealers[index].ID
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
                let productCheck = false;
                let priceCheck = false;
                if (document.getElementById('name').value) {
                    nameCheck = true;
                }
                if (document.getElementById('prod').value) {
                    productCheck = true;
                }
                if (!isNaN(document.getElementById('price').value)) {
                    priceCheck = true;
                }


                if (priceCheck && nameCheck && productCheck) {
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
                            table: 'dealers',
                            cols: 'products, name, retail_price',
                            values: "('" + document.getElementById('prod').value + "', '"
                                + document.getElementById('name').value + "','" + document.getElementById('price').value + "')"
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
                            table: 'dealers',
                            cols: 'products, name, retail_price',
                            id: document.getElementById('id').value,
                            values: "('" + document.getElementById('prod').value + "', '"
                                + document.getElementById('name').value + "','" + document.getElementById('price').value + "')"
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
