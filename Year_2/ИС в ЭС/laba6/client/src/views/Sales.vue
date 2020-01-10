<template>
    <div class="ma-10 mt-4">
        <v-date-picker v-model="picker" landscape type="month"></v-date-picker> <br>
        <v-date-picker v-model="picker" landscape class="mt-5" type="month"></v-date-picker>
    </div>
</template>

<script>
    import axios from 'axios';

    export default {
        name: "Waybills",
        data: () => ({}),

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
        },
    }
</script>

<style scoped>

</style>
