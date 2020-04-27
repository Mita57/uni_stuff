--
-- PostgreSQL database dump
--

-- Dumped from database version 12.2
-- Dumped by pg_dump version 12.2

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

--
-- Name: dough_types; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.dough_types AS ENUM (
    'дрожжевое',
    'дрожжевое сдобное',
    'песочное',
    'слоеное',
    'заварное',
    'бисквитное',
    'жидкое'
);


ALTER TYPE public.dough_types OWNER TO postgres;

--
-- Name: oven_types; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.oven_types AS ENUM (
    'подовая',
    'конвекционная',
    'пицца'
);


ALTER TYPE public.oven_types OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: baking_progs; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.baking_progs (
    id integer NOT NULL,
    temp integer NOT NULL,
    "time" integer NOT NULL,
    steam integer NOT NULL,
    dry integer NOT NULL,
    fan_speed integer NOT NULL
);


ALTER TABLE public.baking_progs OWNER TO postgres;

--
-- Name: baking_progs_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.baking_progs_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.baking_progs_id_seq OWNER TO postgres;

--
-- Name: baking_progs_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.baking_progs_id_seq OWNED BY public.baking_progs.id;


--
-- Name: dough_making_steps; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dough_making_steps (
    dough_id character varying(100) NOT NULL,
    step_number integer NOT NULL,
    instructions text NOT NULL,
    picture bytea NOT NULL
);


ALTER TABLE public.dough_making_steps OWNER TO postgres;

--
-- Name: doughs; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.doughs (
    name character varying(100) NOT NULL,
    type public.dough_types NOT NULL
);


ALTER TABLE public.doughs OWNER TO postgres;

--
-- Name: forms; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.forms (
    name character varying(100) NOT NULL,
    amount integer NOT NULL,
    price integer NOT NULL
);


ALTER TABLE public.forms OWNER TO postgres;

--
-- Name: ovens; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ovens (
    name character varying(100) NOT NULL,
    sheets_amount integer NOT NULL,
    type public.oven_types NOT NULL
);


ALTER TABLE public.ovens OWNER TO postgres;

--
-- Name: products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.products (
    name character varying(100) NOT NULL
);


ALTER TABLE public.products OWNER TO postgres;

--
-- Name: recipe; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.recipe (
    name character varying(100) NOT NULL,
    dough character varying(100) NOT NULL,
    amount integer NOT NULL,
    weight integer NOT NULL,
    baking_prog integer NOT NULL,
    oven_type public.oven_types NOT NULL
);


ALTER TABLE public.recipe OWNER TO postgres;

--
-- Name: recipe_making_steps; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.recipe_making_steps (
    recipe_id character varying(100) NOT NULL,
    step_number integer NOT NULL,
    instuctions text NOT NULL,
    image bytea,
    form character varying(100),
    oven character varying(100)
);


ALTER TABLE public.recipe_making_steps OWNER TO postgres;

--
-- Name: recipe_products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.recipe_products (
    recipe character varying(100) NOT NULL,
    product character varying(100) NOT NULL,
    weight integer NOT NULL
);


ALTER TABLE public.recipe_products OWNER TO postgres;

--
-- Name: baking_progs id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.baking_progs ALTER COLUMN id SET DEFAULT nextval('public.baking_progs_id_seq'::regclass);


--
-- Data for Name: baking_progs; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.baking_progs (id, temp, "time", steam, dry, fan_speed) FROM stdin;
\.


--
-- Data for Name: dough_making_steps; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.dough_making_steps (dough_id, step_number, instructions, picture) FROM stdin;
\.


--
-- Data for Name: doughs; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.doughs (name, type) FROM stdin;
Дрожжевое базовое на закваске	дрожжевое
Дрожжевое итальянское с маслом	дрожжевое
С низким содержанием сдобы	дрожжевое сдобное
С высоким содержанием сдобы	дрожжевое сдобное
\.


--
-- Data for Name: forms; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.forms (name, amount, price) FROM stdin;
\.


--
-- Data for Name: ovens; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.ovens (name, sheets_amount, type) FROM stdin;
Retigo DM5	5	конвекционная
UNOX конвекционная	4	конвекционная
UNOX подовая	1	подовая
Пицца-печь	1	пицца
\.


--
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.products (name) FROM stdin;
\.


--
-- Data for Name: recipe; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.recipe (name, dough, amount, weight, baking_prog, oven_type) FROM stdin;
\.


--
-- Data for Name: recipe_making_steps; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.recipe_making_steps (recipe_id, step_number, instuctions, image, form, oven) FROM stdin;
\.


--
-- Data for Name: recipe_products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.recipe_products (recipe, product, weight) FROM stdin;
\.


--
-- Name: baking_progs_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.baking_progs_id_seq', 1, false);


--
-- Name: baking_progs baking_progs_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.baking_progs
    ADD CONSTRAINT baking_progs_pk PRIMARY KEY (id);


--
-- Name: doughs doughs_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.doughs
    ADD CONSTRAINT doughs_pk PRIMARY KEY (name);


--
-- Name: forms forms_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.forms
    ADD CONSTRAINT forms_pk PRIMARY KEY (name);


--
-- Name: ovens ovens_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ovens
    ADD CONSTRAINT ovens_pk PRIMARY KEY (name);


--
-- Name: products products_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pk PRIMARY KEY (name);


--
-- Name: recipe recipe_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recipe
    ADD CONSTRAINT recipe_pk PRIMARY KEY (name);


--
-- Name: baking_progs_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX baking_progs_id_uindex ON public.baking_progs USING btree (id);


--
-- Name: doughs_name_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX doughs_name_uindex ON public.doughs USING btree (name);


--
-- Name: forms_name_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX forms_name_uindex ON public.forms USING btree (name);


--
-- Name: ovens_name_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX ovens_name_uindex ON public.ovens USING btree (name);


--
-- Name: dough_making_steps dough_making_steps_doughs_name_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dough_making_steps
    ADD CONSTRAINT dough_making_steps_doughs_name_fk FOREIGN KEY (dough_id) REFERENCES public.doughs(name) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: recipe recipe_baking_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recipe
    ADD CONSTRAINT recipe_baking_fk FOREIGN KEY (baking_prog) REFERENCES public.baking_progs(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: recipe recipe_dough_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recipe
    ADD CONSTRAINT recipe_dough_fk FOREIGN KEY (dough) REFERENCES public.doughs(name) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: recipe_making_steps recipe_making_steps_recipe_name_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recipe_making_steps
    ADD CONSTRAINT recipe_making_steps_recipe_name_fk FOREIGN KEY (recipe_id) REFERENCES public.recipe(name);


--
-- PostgreSQL database dump complete
--

