from django.urls import path
from . import views

urlpatterns = [
    path('registration/', views.registerPage, name='register'),
    path('login/', views.loginPage, name='login'),
    path('logout/', views.logoutUser, name='logout'),
    path('article', views.article, name='article'),
    path('article/<int:article_id>', views.get_one_article, name='current_article'),
    path('', views.index, name='index'),
    path('rubrika', views.rubrika, name='rubrika'),
    path('rubric/<int:rubric_id>', views.by_rubric, name='rubric'),
    path('add', views.createArticle, name='createArticle'),
    path('addRubric', views.createRubric, name='createRubric'),
    path('addHashtag', views.createHashtag, name='createHashtag'),

]
