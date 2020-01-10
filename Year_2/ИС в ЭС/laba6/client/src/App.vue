<template>
    <v-app>
        <!-- Header -->
        <v-app-bar app class="blue white--text" absolute short fixed >
            <img class="mr-3 mt-1" :src="require('./assets/logosmall.png')" height="50">
            <v-toolbar-title class="headline text-uppercase" dark>
              <span class="mt-n6">СБИС 2</span>
            </v-toolbar-title>
            <v-toolbar-items class="ml-10">
                <v-btn text class="white--text">Помогите</v-btn>
            </v-toolbar-items>
            <v-spacer></v-spacer>
            <v-toolbar-items>
                <v-btn text class=" white--text" id="cock" to="/login">{{user}}</v-btn>
            </v-toolbar-items>
        </v-app-bar>
        <!-- Sidebar -->
        <v-navigation-drawer app id="side">
            <v-list>
                <v-list-item to="/bills">Чеки</v-list-item>
                <v-list-item to="/dealers">Поставщики</v-list-item>
                <v-list-item to="/employees">Сотрудники</v-list-item>
                <v-list-item to="/products">Товары</v-list-item>
                <v-list-item to="/reports">Отчеты</v-list-item>
                <v-list-item to="/waybills">Накладные</v-list-item>
                <v-list-item to="/sales">Отчет по продажам</v-list-item>
                <v-list-item to="/finance">Отчет по финансам</v-list-item>
            </v-list>
        </v-navigation-drawer>
        <v-content>
            <router-view/>
        </v-content>
    </v-app>
</template>

<script>
    export default {
        name: 'App',
        data() {
            return {
                user: 'Войти',
                channels: [],
                auth_result: ''
            }
        },
        methods: {
           changeName(name) {
               this.user = name;
           }
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
