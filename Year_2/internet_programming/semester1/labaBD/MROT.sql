SELECT count(
    SELECT full_name WHERE begin_date BETWEEN() AND SALARY > (SELECT DISTINCT 10*min_salary from staff)
           ) from staff