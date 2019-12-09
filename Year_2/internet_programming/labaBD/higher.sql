SELECT count(
    SELECT * FROM staff WHERE salary > (avg(basic_salary)) AND begin_date = '2019.12.10'
           ) FROM staff