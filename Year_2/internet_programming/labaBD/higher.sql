SELECT count(full_name) FROM staff GROUP BY full_name, salary HAVING (salary > avg(salary)) and exp = 0