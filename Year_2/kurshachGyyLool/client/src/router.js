import Vue from 'vue';
import Router from 'vue-router';

import Info from "@/views/Info";
import Register from "@/views/Register";

Vue.use(Router);

const router = new Router({
  routes: [
    {
      path: '*',
      redirect: '/info'
    },
    {
      path:'/info',
      name:'Info',
      component: Info
    },
    {
      path:'/register',
      name:'Register',
      component:Register
    }
      ,

  ],
  mode: 'history'
});


export default router;
