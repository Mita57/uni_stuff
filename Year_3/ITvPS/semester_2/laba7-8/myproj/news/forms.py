from django.forms import ModelForm
from .models import Article, Rubric, Hashtag
from django.contrib.auth.forms import UserCreationForm
from django import forms
from django.contrib.auth.models import User


class ArticleForm(ModelForm):
    class Meta:
        model = Article
        fields = '__all__'


class RubricForm(ModelForm):
    class Meta:
        model = Rubric
        fields = ('name',)


class HashtagForm(ModelForm):
    class Meta:
        model = Hashtag
        fields = ('name',)

class CreateUserForm(UserCreationForm):
    class Meta:
        model = User
        fields = ['username', 'email', 'password1', 'password2']

