<template>
    <div class="sign-up mt-4">
        <h3>Авторизация</h3>
        <v-text-field type="text" v-model="email" id="id" placeholder="ID"><br>
        </v-text-field>
        <v-text-field type="password" v-model="password" id="password" placeholder="Пароль"><br></v-text-field>
        </v-text-field>
        <v-btn x-large tile dark class="blue mt-4 sas" @click="loginValidation()">Войти в систему</v-btn>
        <div class="mt-5">{{result}}</div>
    </div>
</template>

<script>
    import axios from 'axios';
    import router from '../router';

    export default {
        name: "Register",
        data() {
            return {
                email: '',
                password: '',
                passwordconf: '',
                nickname: '',
                birth_day: '',
                result: ''
            }
        },
        methods: {
            loginValidation: function () {
                //input validation
                const aw = this;
                let passwordFlag = false;
                let emailFlag = false;

                if(document.getElementById('id').value.length > 3) {
                    emailFlag = true;
                }

                if (document.getElementById('password').value.length > 3) {
                    passwordFlag = true;
                }

                if (passwordFlag && emailFlag) {
                    login(document.getElementById('id').value, document.getElementById('password').value);
                }


                function login(id, pwrd) {
                    axios({
                        headers: {
                            'Access-Control-Allow-Origin': '*',
                            'Content-Type': 'application/json',
                        },
                        method: 'post',
                        url: 'http://localhost:5000/login',
                        data: {
                            id: id,
                            password: pwrd
                        },
                    }).then(function (response) {
                        if (response.data.result == 'fail') {
                            alert('Неправильное имя пользователя или пароль');
                        } else {
                            localStorage.user = response.data.result;
                            aw.user = response.data.result;
                            document.getElementById('cock').innerText = response.data.result;
                            router.push('/bills');
                        }
                    })
                        .catch(function (response) {
                            //handle error
                            console.log(response);
                        })
                }
            }
        }

    }
</script>

<style scoped>
    .sign-up {
        margin: auto;
        text-align: center;
        width: 50%;
    }

    input {
        margin: 10px 0;
        width: 20%;
        padding: 15px;
    }

    button {
        margin-top: 10px;
        width: 10%;
        cursor: pointer;
    }

    span {
        display: block;
        margin-top: 20px;
        font-size: 11px;
    }

    .sas {
        width: 250px;
    }
</style>
