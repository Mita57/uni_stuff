<template>
    <v-data-table :headers="headers" :items="billsinfo" sort-by="ID" class="elevation-1">
        <template v-slot:top>
            <h1 class="ml-3">Информация в чеках</h1>
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
                                    <v-text-field v-model="editedItem.IDProduct" label="ID товара"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.IDBill" label="ID чека"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.amount" label="Количество"></v-text-field>
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
    export default {
        name: "BillsInfo",
        data: () => ({
            dialog: false,
            headers: [
                {text: 'ID товара', value: 'IDProduct'},
                {text: 'ID чека', value: 'IDBill'},
                {text: 'Количество', value: 'amount'},
                {text: 'Действия', value: 'action', sortable: false},
            ],
            billsinfo: [],
            editedIndex: -1,
            editedItem: {
                amount: 0,
                IDProduct: 0,
                IDBill: 0,
            },
            defaultItem: {
                amount: 0,
                IDProduct: 0,
                IDBill: 0,
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
                this.billsinfo = [
                    {
                        amount: 123,
                        IDProduct: 12323,
                        IDBill: 45345,
                    }
                ]

            },

            editItem(item) {
                this.editedIndex = this.billsinfo.indexOf(item);
                this.editedItem = Object.assign({}, item);
                this.dialog = true;
            },

            deleteItem(item) {
                const index = this.billsinfo.indexOf(item);
                confirm('Удалить элемент') && this.dealers.splice(index, 1);
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
                    Object.assign(this.billsinfo[this.editedIndex], this.editedItem);
                } else {
                    this.billsinfo.push(this.editedItem);
                }
                this.close();
            },
        },
    }
</script>

<style scoped>

</style>
