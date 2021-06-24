from django.db import models


class Hashtag(models.Model):
    name = models.CharField(max_length=100)

    def __str__(self):
        return self.name


class Rubric(models.Model):
    name = models.CharField(max_length=100)

    def __str__(self):
        return self.name


class Article(models.Model):
    title = models.CharField(max_length=100)
    keyword = models.CharField(max_length=200)
    annotation = models.TextField()
    rubric = models.ForeignKey(Rubric, null=True, blank=True, on_delete=models.SET_NULL)
    hashtag = models.ManyToManyField(Hashtag, help_text="Выберите хэштэг")

    def __str__(self):
        return self.title

#  python3 manage.py runserver
