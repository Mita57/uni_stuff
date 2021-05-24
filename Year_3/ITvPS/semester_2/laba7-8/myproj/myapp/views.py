from django.shortcuts import render


# Create your views here.
def article(request):
    return render(request, 'article.html', {})


def index(request):
    return render(request, 'index.html', {})


def rubric(request):
    return render(request, 'rubric.html', {})