<template>
    <v-app>
        <!-- Header -->
        <v-app-bar app class="blue white--text" absolute short fixed clipped-right>
            <img class="mr-3 mt-1" :src="require('./assets/logosmall.png')" height="50">
            <v-toolbar-title class="headline text-uppercase" dark>
              <span class="mt-n6">СБИС 2</span>
            </v-toolbar-title>
            <v-toolbar-items class="ml-10">
                <v-btn text class="white--text">Помощь</v-btn>
            </v-toolbar-items>
            <v-spacer></v-spacer>
            <v-toolbar-items>
                <v-btn text class=" white--text" to="/login">{{user}}</v-btn>
            </v-toolbar-items>
        </v-app-bar>
        <!-- Sidebar -->
        <v-navigation-drawer app id="side">
            <v-list two-line subheader>
                <v-list-item v-for="i in 20">
                    <v-list-item-avatar class="sas" tile>
                        <v-img src="./assets/moorava.jpg"></v-img>
                    </v-list-item-avatar>
                    <v-list-item-content>
                        <v-list-item-title>MoorPK</v-list-item-title>
                        <v-list-item-subtitle>Майн форек гетленч</v-list-item-subtitle>
                        <v-list-item-subtitle>Подкасты</v-list-item-subtitle>
                    </v-list-item-content>
                </v-list-item>
            </v-list>
        </v-navigation-drawer>
        <v-content>
            <router-view/>
        </v-content>
    </v-app>
</template>

<script>
    import axios from 'axios';
    import router from "./router";
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
            loginValidation: function () {
                //input validation
                const aw = this;
                let passwordFlag = false;
                let emailFlag = false;
                if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(document.getElementById('email').value)) {
                    emailFlag = true;
                    document.getElementById('email').style.backgroundColor = '#424242';
                } else {
                    document.getElementById('email').style.backgroundColor = 'darkred';
                    emailFlag = false;
                }
                if (document.getElementById('password').value.length >= 4) {
                    passwordFlag = true;
                    document.getElementById('password').style.backgroundColor = '#424242';
                } else {
                    document.getElementById('password').style.backgroundColor = 'darkred';
                    passwordFlag = false;
                }
                if (passwordFlag && emailFlag) {
                    login(document.getElementById('email').value, document.getElementById('password').value);
                }
                function login(email, pwrd) {
                    axios({
                        headers: {
                            'Access-Control-Allow-Origin': '*',
                            'Content-Type': 'application/json',
                        },
                        method: 'post',
                        url: 'http://localhost:5000/login',
                        data: {
                            email: email,
                            password: pwrd
                        },
                    }).then(function (response) {
                        if (response.data.result == 'fail') {
                            aw.auth_result = 'Неправильное имя пользователя или пароль';
                        }
                        else {
                            localStorage.user = response.data.result;
                            aw.user = response.data.result;
                        }
                    })
                        .catch(function (response) {
                            //handle error
                            console.log(response);
                        })
                }
            },
            search(){
                if(document.getElementById('search').value.length > 0) {
                    router.push('search/' + document.getElementById('search').value);
                }
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
