<template>
    <div class="sign-up mt-4">
        <h3>Авторизация</h3>
        <v-text-field type="text" v-model="email" id="emailReg" placeholder="ID"><br>
        </v-text-field>
        <v-text-field type="password" v-model="password" id="passwordReg" placeholder="Пароль"><br></v-text-field>
        </v-text-field>
        <v-btn x-large tile dark class="blue mt-4 sas" @click="signUpValidation()">Войти в систему</v-btn>
        <div class="mt-5">{{result}}</div>
    </div>
</template>

<script>
    import axios from 'axios';
    import App from '../App.vue';

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
            signUpValidation() {
                this.$parent.user = document.getElementById('emailReg');
                document.getElementById('cock').innerText = document.getElementById('emailReg').value;
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
