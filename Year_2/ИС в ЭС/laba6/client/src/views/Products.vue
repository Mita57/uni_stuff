<template>
    <v-data-table :headers="headers" :items="products" sort-by="ID" class="elevation-1">
        <template v-slot:top>
            <h1 class="ml-3">Продукция</h1>
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
                                    <v-text-field v-model="editedItem.ID" label="ID товара"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.price" label="Цена"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.name" label="Название"></v-text-field>
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
        name: "Products",
        data: () => ({
            dialog: false,
            headers: [
                {text: 'ID', align: 'left', value: 'ID'},
                {text: 'Цена', value: 'price'},
                {text: 'Навзвание', value: 'name'},
                {text: 'Действия', value: 'action', sortable: false},
            ],
            products: [],
            editedIndex: -1,
            editedItem: {
                price: 0,
                name: '',
            },
            defaultItem: {
                price: 0,
                name: '',
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
                this.editedIndex = this.products.indexOf(item);
                this.editedItem = Object.assign({}, item);
                this.dialog = true;
            },

            deleteItem(item) {
                const index = this.products.indexOf(item);
                confirm('Удалить элемент') && this.products.splice(index, 1);
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
                    Object.assign(this.products[this.editedIndex], this.editedItem);
                } else {
                    this.products.push(this.editedItem);
                }
                this.close();
            },
        },
    }
</script>

<style scoped>

</style>
