<template>
    <v-data-table :headers="headers" :items="dealers" sort-by="ID" class="elevation-1">
        <template v-slot:top>
            <h1 class="ml-3">Накладные</h1>
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
                                    <v-text-field v-model="editedItem.productID" label="ID товара"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.dealerID" label="ID накладной"></v-text-field>
                                </v-col>
                                <v-col cols="12" sm="6" md="4">
                                    <v-text-field v-model="editedItem.amount" label="Количество"></v-text-field>
                                </v-col>
                            </v-row>
                        </v-container>
                    </v-card-text>

                    <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn color="blue darken-1" text @click="close">Cancel</v-btn>
                        <v-btn color="blue darken-1" text @click="save">Save</v-btn>
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
        name: "WaybillEntries",
        data: () => ({
            dialog: false,
            headers: [
                {text: 'ID товара', align: 'left', value: 'IDproduct'},
                {text: 'ID накладной', value: 'IDwaybill'},
                {text: 'Количество товара', value: 'amount'},
                {text: 'Действия', value: 'action', sortable: false},
            ],
            waybillentries: [],
            editedIndex: -1,
            editedItem: {
                IDproduct: '',
                IDwaybill: '',
                amount: 0,
            },
            defaultItem: {
                IDproduct: '',
                IDwaybill: '',
                amount: 0,
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

            },

            editItem(item) {
                this.editedIndex = this.waybillentries.indexOf(item);
                this.editedItem = Object.assign({}, item);
                this.dialog = true;
            },

            deleteItem(item) {
                const index = this.waybillentries.indexOf(item);
                confirm('Удалить элемент') && this.waybillentries.splice(index, 1);
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
                    Object.assign(this.waybillentries[this.editedIndex], this.editedItem);
                } else {
                    this.waybillentries.push(this.editedItem);
                }
                this.close();
            },
        },
    }
</script>

<style scoped>

</style>
