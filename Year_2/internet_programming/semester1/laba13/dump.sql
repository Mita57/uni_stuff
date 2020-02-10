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
-- Name: objects; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.objects (
    id integer NOT NULL,
    type character varying,
    month_payment integer NOT NULL,
    info character varying(50)
);


ALTER TABLE public.objects OWNER TO postgres;

--
-- Name: objects_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.objects_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.objects_id_seq OWNER TO postgres;

--
-- Name: objects_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.objects_id_seq OWNED BY public.objects.id;


--
-- Name: rental; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.rental (
    id integer NOT NULL,
    begin_date date NOT NULL,
    period integer NOT NULL,
    object_id integer NOT NULL,
    rentor_id integer NOT NULL
);


ALTER TABLE public.rental OWNER TO postgres;

--
-- Name: rental_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.rental_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.rental_id_seq OWNER TO postgres;

--
-- Name: rental_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.rental_id_seq OWNED BY public.rental.id;


--
-- Name: rentors; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.rentors (
    id integer NOT NULL,
    name character varying(100) NOT NULL
);


ALTER TABLE public.rentors OWNER TO postgres;

--
-- Name: rentors_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.rentors_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.rentors_id_seq OWNER TO postgres;

--
-- Name: rentors_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.rentors_id_seq OWNED BY public.rentors.id;


--
-- Name: objects id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objects ALTER COLUMN id SET DEFAULT nextval('public.objects_id_seq'::regclass);


--
-- Name: rental id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rental ALTER COLUMN id SET DEFAULT nextval('public.rental_id_seq'::regclass);


--
-- Name: rentors id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rentors ALTER COLUMN id SET DEFAULT nextval('public.rentors_id_seq'::regclass);


--
-- Data for Name: objects; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.objects (id, type, month_payment, info) FROM stdin;
8	Планета	323	Марс
4	Хрущевка	23	Пятиэтажная
6	Страна	501	Россия
2	Коробка из земли	100	Майнкрафт
3	Аэропорт	10	Рощино
5	Подвал	231	Из ЗС
7	Страна	239	США
9	Коробка	455	Из дивана
10	Коробка из земли	200	В незере
11	Подвал 	444	Винный
1	Коробка	300	bucksss
12	Коробка	231	Несквик
\.


--
-- Data for Name: rental; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.rental (id, begin_date, period, object_id, rentor_id) FROM stdin;
15	2019-07-04	4	7	7
21	2004-08-01	3	4	8
20	2019-09-12	5	8	5
24	2016-05-23	3	2	5
26	2005-05-07	4	4	4
28	2011-09-22	2	2	2
25	2014-03-24	5	3	2
14	2012-06-17	5	9	4
17	2008-01-24	3	2	3
7	2000-09-04	3	3	9
2	2016-06-08	1	4	5
8	2009-07-13	4	6	3
10	2011-01-10	4	9	8
19	2017-03-16	5	6	1
11	2018-10-15	5	4	5
16	2001-07-24	3	5	1
12	2003-04-03	2	2	2
27	2014-09-20	3	8	1
1	2014-09-07	1	4	4
6	2018-10-07	2	4	2
22	2018-03-01	5	4	7
18	2015-09-07	4	5	2
\.


--
-- Data for Name: rentors; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.rentors (id, name) FROM stdin;
2	Billy Herrington
3	Ricardo Milos
4	Bruno Pelletier
5	James Hetfield
7	Lars Ulrich
8	Cliff Burton
9	Jason Newsted
10	Ozzy Osbourne
11	Tony Iommi
12	Bill Ward
13	Geezer Butler
14	Dave Mustaine
1	Даяна Исмакова
\.


--
-- Name: objects_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.objects_id_seq', 12, true);


--
-- Name: rental_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.rental_id_seq', 4, true);


--
-- Name: rentors_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.rentors_id_seq', 1, false);


--
-- Name: objects objects_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.objects
    ADD CONSTRAINT objects_pk PRIMARY KEY (id);


--
-- Name: rental rental_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_pk PRIMARY KEY (id);


--
-- Name: rentors rentors_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rentors
    ADD CONSTRAINT rentors_pk PRIMARY KEY (id);


--
-- Name: objects_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX objects_id_uindex ON public.objects USING btree (id);


--
-- Name: rental_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX rental_id_uindex ON public.rental USING btree (id);


--
-- Name: rentors_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX rentors_id_uindex ON public.rentors USING btree (id);


--
-- Name: rental rental_objects_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_objects_id_fk FOREIGN KEY (object_id) REFERENCES public.objects(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: rental rental_rentors_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_rentors_id_fk FOREIGN KEY (rentor_id) REFERENCES public.rentors(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

