<!DOCTYPE html>
<html>
<head>
	<title>{{$name->staff}}</title>
</head>
<body>
	@foreach($staff as $s)
		{{$s->FIO}}<br>
		Стаж: {{$s->Stage}}<br>
		Номер телефона: {{$s->Phone}}<br><br>
	@endforeach
</body>
</html>