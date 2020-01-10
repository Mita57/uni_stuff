<template>

</template>

<script>
    export default {
        name: 'Finance',
        data() {
            return {
                user: 'Войти',
                channels: [],
                auth_result: ''
            }
        },
        methods: {
        }
    };
</script>

<style>
    a {
        text-decoration: none;
        color: white;
    }
    #search {
        width: 500px;
    }
    .v-navigation-drawer__content::-webkit-scrollbar {
        width: 6px;
        background-color: #F5F5F5;
    }
    .v-navigation-drawer__content::-webkit-scrollbar-thumb {
        box-shadow: inset 0 0 5px grey;
        background: dodgerblue;
    }
</style>
//TODO: this
