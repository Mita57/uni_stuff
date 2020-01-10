--
-- PostgreSQL database dump
--

-- Dumped from database version 12.1
-- Dumped by pg_dump version 12.1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: bills; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bills (
    id integer NOT NULL,
    price integer NOT NULL,
    employee_id integer
);


ALTER TABLE public.bills OWNER TO postgres;

--
-- Name: bills_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.bills_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.bills_id_seq OWNER TO postgres;

--
-- Name: bills_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.bills_id_seq OWNED BY public.bills.id;


--
-- Name: dealers; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dealers (
    id integer NOT NULL,
    name character varying(50) NOT NULL,
    retail_price integer NOT NULL,
    product_id integer
);


ALTER TABLE public.dealers OWNER TO postgres;

--
-- Name: dealers_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.dealers_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.dealers_id_seq OWNER TO postgres;

--
-- Name: dealers_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.dealers_id_seq OWNED BY public.dealers.id;


--
-- Name: employees; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.employees (
    id integer NOT NULL,
    name character varying(50) NOT NULL,
    "position" character varying(50) NOT NULL,
    salary integer NOT NULL,
    passport character varying(50) NOT NULL
);


ALTER TABLE public.employees OWNER TO postgres;

--
-- Name: employees_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.employees_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.employees_id_seq OWNER TO postgres;

--
-- Name: employees_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.employees_id_seq OWNED BY public.employees.id;


--
-- Name: products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.products (
    id integer NOT NULL,
    name character varying(50) NOT NULL
);


ALTER TABLE public.products OWNER TO postgres;

--
-- Name: product_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.product_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.product_id_seq OWNER TO postgres;

--
-- Name: product_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.product_id_seq OWNED BY public.products.id;


--
-- Name: products_bills; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.products_bills (
    product_id integer NOT NULL,
    bill_id integer NOT NULL
);


ALTER TABLE public.products_bills OWNER TO postgres;

--
-- Name: reports; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.reports (
    id integer NOT NULL,
    begin date NOT NULL,
    "end" date NOT NULL,
    income integer NOT NULL,
    outcome integer NOT NULL,
    sale_volumes integer NOT NULL
);


ALTER TABLE public.reports OWNER TO postgres;

--
-- Name: reports_bills; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.reports_bills (
    report_id integer,
    bill_id integer
);


ALTER TABLE public.reports_bills OWNER TO postgres;

--
-- Name: reports_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.reports_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.reports_id_seq OWNER TO postgres;

--
-- Name: reports_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.reports_id_seq OWNED BY public.reports.id;


--
-- Name: waybills; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.waybills (
    id integer NOT NULL,
    date date NOT NULL,
    amount integer NOT NULL,
    dealer_id integer
);


ALTER TABLE public.waybills OWNER TO postgres;

--
-- Name: waybills_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.waybills_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.waybills_id_seq OWNER TO postgres;

--
-- Name: waybills_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.waybills_id_seq OWNED BY public.waybills.id;


--
-- Name: waybills_products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.waybills_products (
    waybill_id integer NOT NULL,
    product_id integer
);


ALTER TABLE public.waybills_products OWNER TO postgres;

--
-- Name: bills id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bills ALTER COLUMN id SET DEFAULT nextval('public.bills_id_seq'::regclass);


--
-- Name: dealers id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dealers ALTER COLUMN id SET DEFAULT nextval('public.dealers_id_seq'::regclass);


--
-- Name: employees id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees ALTER COLUMN id SET DEFAULT nextval('public.employees_id_seq'::regclass);


--
-- Name: products id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products ALTER COLUMN id SET DEFAULT nextval('public.product_id_seq'::regclass);


--
-- Name: reports id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports ALTER COLUMN id SET DEFAULT nextval('public.reports_id_seq'::regclass);


--
-- Name: waybills id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.waybills ALTER COLUMN id SET DEFAULT nextval('public.waybills_id_seq'::regclass);


--
-- Data for Name: bills; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.bills (id, price, employee_id) FROM stdin;
1	360	1
\.


--
-- Data for Name: dealers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.dealers (id, name, retail_price, product_id) FROM stdin;
1	COWard	50	1
7	Bootleggasd	400	7
6	NUTtela	350	6
3	Sugary	80	3
5	NUTtela	200	5
2	POWder	70	2
4	Navi	160	4
\.


--
-- Data for Name: employees; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.employees (id, name, "position", salary, passport) FROM stdin;
1	Джеймс Хэтфилд	Кассир	25000	7114 073599
2	Кирк Хэммет	Кассир	30000	7116 444784
3	Ларс Ульрих	Пекарь	35000	7113 459434
4	Клифф Бертон	Старший Пекарь	40000	7113 565243
5	Дейв Мастейн	Пекарь	30000	7112 756315
6	Ван Даркхолм	Технолог	60000	7115 613784
7	Билли Хэррингтон	Уборщик	25000	7111 984323
8	2wrfsdfsdf	sdfsfsdff	3000	sf9589595
\.


--
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.products (id, name) FROM stdin;
2	Мука
7	Яйца
1	Молоко
6	Орехи миндаль
3	Сахар
4	Дрожжи
5	Орехи грецкие
\.


--
-- Data for Name: products_bills; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.products_bills (product_id, bill_id) FROM stdin;
5	1
5	1
5	1
7	1
\.


--
-- Data for Name: reports; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.reports (id, begin, "end", income, outcome, sale_volumes) FROM stdin;
1	2017-01-01	2017-01-31	9000	8000	650
2	2017-02-01	2017-02-28	8500	7000	600
3	2017-03-01	2017-03-31	10000	7000	800
\.


--
-- Data for Name: reports_bills; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.reports_bills (report_id, bill_id) FROM stdin;
\.


--
-- Data for Name: waybills; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.waybills (id, date, amount, dealer_id) FROM stdin;
1	2020-01-07	200	2
2	2019-05-16	300	1
3	2019-04-16	158	5
\.


--
-- Data for Name: waybills_products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.waybills_products (waybill_id, product_id) FROM stdin;
\.


--
-- Name: bills_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.bills_id_seq', 1, true);


--
-- Name: dealers_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.dealers_id_seq', 16, true);


--
-- Name: employees_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.employees_id_seq', 8, true);


--
-- Name: product_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.product_id_seq', 10, true);


--
-- Name: reports_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.reports_id_seq', 3, true);


--
-- Name: waybills_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.waybills_id_seq', 3, true);


--
-- Name: bills bills_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bills
    ADD CONSTRAINT bills_pk PRIMARY KEY (id);


--
-- Name: dealers dealers_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dealers
    ADD CONSTRAINT dealers_pk PRIMARY KEY (id);


--
-- Name: employees employees_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees
    ADD CONSTRAINT employees_pk PRIMARY KEY (id);


--
-- Name: products product_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT product_pk PRIMARY KEY (id);


--
-- Name: reports reports_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports
    ADD CONSTRAINT reports_pk PRIMARY KEY (id);


--
-- Name: waybills waybills_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.waybills
    ADD CONSTRAINT waybills_pk PRIMARY KEY (id);


--
-- Name: bills_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX bills_id_uindex ON public.bills USING btree (id);


--
-- Name: dealers_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX dealers_id_uindex ON public.dealers USING btree (id);


--
-- Name: employees_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX employees_id_uindex ON public.employees USING btree (id);


--
-- Name: product_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX product_id_uindex ON public.products USING btree (id);


--
-- Name: reports_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX reports_id_uindex ON public.reports USING btree (id);


--
-- Name: waybills_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX waybills_id_uindex ON public.waybills USING btree (id);


--
-- Name: bills bills_employees_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bills
    ADD CONSTRAINT bills_employees_id_fk FOREIGN KEY (employee_id) REFERENCES public.employees(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: products_bills products_bills_bills_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products_bills
    ADD CONSTRAINT products_bills_bills_id_fk FOREIGN KEY (bill_id) REFERENCES public.bills(id);


--
-- Name: products_bills products_bills_products_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products_bills
    ADD CONSTRAINT products_bills_products_id_fk FOREIGN KEY (product_id) REFERENCES public.products(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: reports_bills reports_bills_bills_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports_bills
    ADD CONSTRAINT reports_bills_bills_id_fk FOREIGN KEY (bill_id) REFERENCES public.bills(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: reports_bills reports_bills_reports_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports_bills
    ADD CONSTRAINT reports_bills_reports_id_fk FOREIGN KEY (report_id) REFERENCES public.reports(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: waybills waybills_dealers_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.waybills
    ADD CONSTRAINT waybills_dealers_id_fk FOREIGN KEY (dealer_id) REFERENCES public.dealers(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: waybills_products waybills_products_products_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.waybills_products
    ADD CONSTRAINT waybills_products_products_id_fk FOREIGN KEY (product_id) REFERENCES public.products(id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- Name: waybills_products waybills_products_waybills_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.waybills_products
    ADD CONSTRAINT waybills_products_waybills_id_fk FOREIGN KEY (waybill_id) REFERENCES public.waybills(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

