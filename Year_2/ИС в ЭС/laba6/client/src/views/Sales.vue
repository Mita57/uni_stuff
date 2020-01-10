<template>
    <div class="ma-10 mt-4">
        <v-date-picker v-model="begin" landscape type="month"></v-date-picker>
        <v-btn class="success ml-4 tile" @click="count()">Посчитать</v-btn>
        <br>
        <v-date-picker v-model="end" landscape class="mt-5" type="month"></v-date-picker>
        <div class="sas">
            <v-text-field id="income" disabled label="Доходы" value=" "></v-text-field>
            <v-text-field id="outcome" disabled label="Расходы" value=" "></v-text-field>
            <v-text-field id="diff" disabled label="Разница" value=" "></v-text-field>
            <v-text-field id="volume" disabled label="Объем продаж" value=" "></v-text-field>
        </div>

    </div>
</template>

<script>
    import axios from 'axios';

    export default {
        name: "Sales",
        data: () => ({
            begin: new Date().toISOString().substr(0, 7),
            end: new Date().toISOString().substr(0, 7),
            reports: [],
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
                axios.get('http://localhost:5000/getInfo?table=reports')
                    .then(function (res) {
                        let goodBills = [];
                        for (let i = 0; i < res.data.length; i++) {
                            let elem = {
                                ID: res.data[i][0],
                                begin: res.data[i][1],
                                end: res.data[i][2],
                                income: res.data[i][3],
                                outcome: res.data[i][4],
                                volume: res.data[i][5]
                            };
                            goodBills.push(elem);
                        }
                        rw.reports = goodBills;
                    })
                    .catch(function (res) {
                        //handle error
                        console.log(res);
                    })

            },

            count() {
                let months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug'
                    , 'Sep', 'Oct', 'Nov', 'Dec'];

                let beginDate = this.begin;
                let endDate = this.end;

                let queryBeginYear = beginDate.split('-')[0];
                let queryBeginMonth = beginDate.split('-')[1];
                let queryBeginTime = new Date(queryBeginYear, queryBeginMonth);

                let queryEndYear = endDate.split('-')[0];
                let queryEndMonth = endDate.split('-')[1];
                let queryEndTime = new Date(queryEndYear, queryEndMonth);

                let incomeSum = 0;
                let outcomeSum = 0;
                let volumeSum = 0;

                for (let i = 0; i < this.reports.length; i++) {
                    let beginYear = this.reports[i].begin.split(' ')[3];
                    let beginMonth = this.reports[i].begin.split(' ')[2];
                    for (let i = 0; i < months.length; i++) {
                        if (beginMonth == months[i]) {
                            beginMonth = i + 1;
                            break;
                        }
                    }
                    let beginTime = new Date(beginYear, beginMonth);


                    let endYear = this.reports[i].end.split(' ')[3];
                    let endMonth = this.reports[i].end.split(' ')[2];
                    for (let i = 0; i < months.length; i++) {
                        if (endMonth == months[i]) {
                            endMonth = i + 1;
                            break;
                        }
                    }
                    console.log(endYear, endMonth);
                    let endTime = new Date(endYear, endMonth);

                    console.log(beginTime, endTime);

                    if (queryBeginTime.getTime() <= beginTime.getTime() && queryEndTime.getTime() >= endTime.getTime()) {
                        incomeSum += this.reports[i].income;
                        outcomeSum += this.reports[i].outcome;
                        volumeSum += this.reports[i].volume;
                    }
                }

                let difference = incomeSum - outcomeSum;
                document.getElementById('income').value = incomeSum;
                document.getElementById('outcome').value = outcomeSum;
                document.getElementById('diff').value = difference;
                document.getElementById('volume').value = difference;
            }
        },
    }
</script>

<style scoped>
    .sas {
        margin-left: 50%;
        margin-top: -450px;
    }
</style>
