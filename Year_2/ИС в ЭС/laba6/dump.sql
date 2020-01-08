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
    employeeid integer
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
    products text,
    price integer,
    id integer NOT NULL
);


ALTER TABLE public.dealers OWNER TO postgres;

--
-- Name: dealers_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.dealers_id_seq
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
    name character varying(100) NOT NULL,
    passport integer NOT NULL,
    salary integer,
    "position" character varying(50) NOT NULL,
    snils integer NOT NULL,
    inn integer NOT NULL
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
    name character varying(50) NOT NULL,
    price integer NOT NULL,
    id integer NOT NULL
);


ALTER TABLE public.products OWNER TO postgres;

--
-- Name: products_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.products_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.products_id_seq OWNER TO postgres;

--
-- Name: products_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.products_id_seq OWNED BY public.products.id;


--
-- Name: reports; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.reports (
    id integer NOT NULL,
    begin date NOT NULL,
    "end" date NOT NULL,
    volumes integer,
    expenses integer
);


ALTER TABLE public.reports OWNER TO postgres;

--
-- Name: report_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.report_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.report_id_seq OWNER TO postgres;

--
-- Name: report_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.report_id_seq OWNED BY public.reports.id;


--
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id character varying NOT NULL,
    password character varying(50) NOT NULL
);


ALTER TABLE public.users OWNER TO postgres;

--
-- Name: waybillentry; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.waybillentry (
    productid integer,
    waybillid integer,
    amount integer
);


ALTER TABLE public.waybillentry OWNER TO postgres;

--
-- Name: waybills; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.waybills (
    number integer NOT NULL,
    date date NOT NULL,
    amount integer NOT NULL,
    dealerid integer
);


ALTER TABLE public.waybills OWNER TO postgres;

--
-- Name: waybills_number_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.waybills_number_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.waybills_number_seq OWNER TO postgres;

--
-- Name: waybills_number_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.waybills_number_seq OWNED BY public.waybills.number;


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

ALTER TABLE ONLY public.products ALTER COLUMN id SET DEFAULT nextval('public.products_id_seq'::regclass);


--
-- Name: reports id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports ALTER COLUMN id SET DEFAULT nextval('public.report_id_seq'::regclass);


--
-- Name: waybills number; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.waybills ALTER COLUMN number SET DEFAULT nextval('public.waybills_number_seq'::regclass);


--
-- Data for Name: bills; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.bills (id, price, employeeid) FROM stdin;
\.


--
-- Data for Name: dealers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.dealers (products, price, id) FROM stdin;
\.


--
-- Data for Name: employees; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.employees (id, name, passport, salary, "position", snils, inn) FROM stdin;
\.


--
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.products (name, price, id) FROM stdin;
\.


--
-- Data for Name: reports; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.reports (id, begin, "end", volumes, expenses) FROM stdin;
\.


--
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id, password) FROM stdin;
\.


--
-- Data for Name: waybillentry; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.waybillentry (productid, waybillid, amount) FROM stdin;
\.


--
-- Data for Name: waybills; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.waybills (number, date, amount, dealerid) FROM stdin;
\.


--
-- Name: bills_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.bills_id_seq', 1, false);


--
-- Name: dealers_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.dealers_id_seq', 1, false);


--
-- Name: employees_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.employees_id_seq', 1, false);


--
-- Name: products_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.products_id_seq', 1, false);


--
-- Name: report_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.report_id_seq', 1, false);


--
-- Name: waybills_number_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.waybills_number_seq', 1, false);


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
-- Name: products products_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pk PRIMARY KEY (id);


--
-- Name: reports report_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reports
    ADD CONSTRAINT report_pk PRIMARY KEY (id);


--
-- Name: users users_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pk PRIMARY KEY (id);


--
-- Name: waybills waybills_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.waybills
    ADD CONSTRAINT waybills_pk PRIMARY KEY (number);


--
-- Name: bills_employeeid_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX bills_employeeid_uindex ON public.bills USING btree (employeeid);


--
-- Name: bills_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX bills_id_uindex ON public.bills USING btree (id);


--
-- Name: employees_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX employees_id_uindex ON public.employees USING btree (id);


--
-- Name: products_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX products_id_uindex ON public.products USING btree (id);


--
-- Name: report_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX report_id_uindex ON public.reports USING btree (id);


--
-- Name: users_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX users_id_uindex ON public.users USING btree (id);


--
-- Name: waybillentry_productid_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX waybillentry_productid_uindex ON public.waybillentry USING btree (productid);


--
-- Name: waybillentry_waybillid_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX waybillentry_waybillid_uindex ON public.waybillentry USING btree (waybillid);


--
-- Name: waybills_dealerid_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX waybills_dealerid_uindex ON public.waybills USING btree (dealerid);


--
-- Name: dealers dealers_waybills_dealerid_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dealers
    ADD CONSTRAINT dealers_waybills_dealerid_fk FOREIGN KEY (id) REFERENCES public.waybills(dealerid) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: employees employees_bills_employeeid_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees
    ADD CONSTRAINT employees_bills_employeeid_fk FOREIGN KEY (id) REFERENCES public.bills(employeeid) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: products products_waybillentry_productid_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_waybillentry_productid_fk FOREIGN KEY (id) REFERENCES public.waybillentry(productid) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: waybills waybills_waybillentry_waybillid_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.waybills
    ADD CONSTRAINT waybills_waybillentry_waybillid_fk FOREIGN KEY (number) REFERENCES public.waybillentry(waybillid);


--
-- PostgreSQL database dump complete
--

