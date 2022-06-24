-- BADC5, IFSP-PRC, 2022 (1s)
-- Isabela Aquino de Medeiros - PC3010571
-- Jéssica Carolina da Silva - PC3008916
-- Lucy K. Arquejada Velasco - PC3015581
-- Mariane Bedia De Andrade - PC3010767
-- Vitória Elisa Fernandes - PC3011666


-- Instruções básicas:
-- Nomear o script como GrupoX.sql (onde X e' tema do grupo)
-- Seguir rigorosamente a sintaxe do PostgreSQL
-- Este script precisa ser escrito de modo que possa ser executado completamente sem apresentar erros

-- ----------------------------
-- [1] ESQUEMAS 

CREATE SCHEMA cadastro;
CREATE SCHEMA rotinas;

-- [2] TABELAS
-- Criação das tabelas e de suas restrições (chaves primárias, unicidades, valores padrão, checagem e não nulos)
-- Pelo menos 1 UNIQUE, 1 DEFAULT, 1 CHECK
-- Definição das chaves estrangeiras das tabelas com ações referenciais engatilhadas
-- As restricoes criadas com ALTER TABLE devem aparecer logo apos a tabela correspondente

CREATE TABLE cadastro.curso
(
    cod_curso serial NOT NULL,
    nome_curso character(50) NOT NULL,
    descricao_curso character(200),
    qtd_semestre int,
    CONSTRAINT curso_pkey PRIMARY KEY (cod_curso)
);

ALTER TABLE cadastro.curso
ADD CONSTRAINT nome_curso_unique UNIQUE (nome_curso);

CREATE TABLE cadastro.professor
(
    cod_professor serial NOT NULL,
    nome_professor character(100) NOT NULL,
    data_nasc date NOT NULL,
    salario float,
    CONSTRAINT professor_pkey PRIMARY KEY (cod_professor),
    CONSTRAINT salario_ck CHECK (salario > 0)
);

ALTER TABLE cadastro.professor
ADD CONSTRAINT nome_prof_unique UNIQUE (nome_professor);

CREATE TABLE cadastro.disciplina
(
    cod_disciplina serial NOT NULL,
    nome_disciplina character(50) NOT NULL,
    data_inicio date NOT NULL,
    data_encerramento date NOT NULL,
    qtd_aulas bigint NOT NULL,
    cod_prof bigint NOT NULL,
    cod_curso bigint NOT NULL,
    CONSTRAINT disciplina_pkey PRIMARY KEY (cod_disciplina),
    CONSTRAINT fk_curso FOREIGN KEY (cod_curso)
        REFERENCES cadastro.curso (cod_curso),
    CONSTRAINT fk_professor FOREIGN KEY (cod_prof)
        REFERENCES cadastro.professor (cod_professor) ,
    CONSTRAINT data_inicio_ck CHECK (data_inicio >= CURRENT_DATE),
    CONSTRAINT data_encerramento_ck CHECK (data_encerramento >= CURRENT_DATE)
);

ALTER TABLE cadastro.disciplina
ADD CONSTRAINT nome_disc_unique UNIQUE (nome_disciplina);

ALTER TABLE cadastro.disciplina ALTER COLUMN data_inicio SET DEFAULT '06.02.2024';

CREATE TABLE cadastro.login(
    cod_login serial NOT NULL,
    login character(50) NOT NULL,
    senha character(50) NOT NULL,
    tipo_usuario character(15) NOT NULL
);


ALTER  TABLE cadastro.disciplina
DROP CONSTRAINT fk_professor;

ALTER  TABLE cadastro.disciplina
Add CONSTRAINT fk_professor
FOREIGN KEY (cod_prof) REFERENCES cadastro.professor(cod_professor) 
ON DELETE SET NULL ON UPDATE CASCADE;

ALTER  TABLE cadastro.disciplina
DROP CONSTRAINT fk_curso;

ALTER  TABLE cadastro.disciplina
Add CONSTRAINT fk_curso
FOREIGN KEY (cod_curso) REFERENCES cadastro.curso(cod_curso) 
ON DELETE SET NULL ON UPDATE CASCADE;

ALTER TABLE cadastro.disciplina ALTER COLUMN cod_curso DROP NOT NULL;

-- [3] CARGA DE DADOS
-- 100 tuplas no total e identificar quem fez as insercoes

-- 20 INSERTs - Isabela Aquino de Medeiros
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Augusto Costela', '01.03.1987', 500.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Maria da Conceicao', '01.03.1990', 15486.50);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Luiz Henrique Pinto', '10.02.1986', 94562.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Melissa Cardoso', '14.01.1976', 65749.55);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Heitor Fogaca', '25.06.1978', 28446.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Arthur Nascimento', '12.11.1983', 2654.87);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Lara Viana', '17.06.1988', 600.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Paulo Martins Assuncao', '18.05.1990', 6548.54);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Erick Moreira', '23.08.1989', 9878.99);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Gustavo Guanabara', '08.12.1979', 3000.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Marcele Adriotta', '04.04.1984', 28000.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Vitor Ramos', '29.09.1987', 7000.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Leandro Fonseca Junior', '06.12.1992', 6578.44);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Roberta Muniz Teixeira', '01.07.1972', 4000.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Mariana Rissolini', '28.05.1989', 3245.11);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Mariana Alexandrino Rodrigues', '12.09.1970', 15000.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Maria Cecília Porto', '18.07.1976', 879.99);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Davi Roberto Angolinni', '28.08.1979', 2222.22);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Rafaela Angelini', '19.10.1992', 9875.12);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Raquel Farias', '30.01.1990', 900.00);



-- 20 INSERTs - Jéssica Carolina da Silva
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Augusto Stefanelli', '24.07.1975', 13493.50);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Felipe Siqueira Neto', '18.03.1991', 1019.40);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Rodrigo Willian Pinheiro', '09.09.1989', 1434.80);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Isabela Porto Queiroz', '01.01.1981', 2391.99);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Roberto Costela', '31.12.1986', 6978.55);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Camila Nascimento', '23.09.1978', 11207.50);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Alexandre Perin', '25.06.1977', 9540.00);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Rodrigo Teixeira', '07.06.1985', 8613.90);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Orlando Genoval Rabusquini', '19.10.1985', 6512.44);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Olivia Mattos', '20.04.1988', 9841.66);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Roberta Lazarini Rossato', '20.04.1988', 3294.80);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Joao Munhoz', '01.03.1987', 9032.40);
INSERT INTO cadastro.professor (nome_professor, data_nasc, salario) VALUES ('Joao Pedrosa Filho', '07.12.1991', 8132.56);

INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Engenharia, Ciencias exatas, Tecnologia e suas aplicacoes', 'Engenharia da Computacao', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Tecnologia e suas aplicacoes', 'Ciencia da Computacao', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Tecnologia e suas aplicacoes', 'Analise e Desenvolvimento de sistemas', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Tecnologia e suas aplicacoes', 'DBA', 6);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Tecnologia e suas aplicacoes', 'Desenvolvimento Web', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Tecnologia e suas aplicacoes', 'Design de Games 3D', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Engenharia, Ciencias exatas e suas aplicacoes','Engenharia Eletrica', 10);

-- 20 INSERTs - Lucy K. Arquejada Velasco

INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Engenharia, Ciencias exatas e suas aplicacoes', 'Engenharia dos alimentos', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Engenharia, Ciencias exatas e suas aplicacoes', 'Engenharia Civil', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Engenharia, Ciencias exatas e suas aplicacoes', 'Engenharia Mecanica', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Engenharia, Ciencias exatas e suas aplicacoes', 'Engenharia dos materiais', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias exatas e suas aplicacoes', 'Matematica', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias exatas e suas aplicacoes', 'Fisica', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias exatas e suas aplicacoes', 'Astronomia', 6);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias exatas e suas aplicacoes', 'Matematica Aplicada', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias exatas e suas aplicacoes', 'Ciencias contabeis', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias exatas e suas aplicacoes', 'Ciencias economicas', 6);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Licenciatura','Letras', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Licenciatura', 'Ingles', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Licenciatura', 'Historia', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Licenciatura', 'Libras', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias exatas e suas aplicacoes', 'Quimica', 10); 
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias biologicas e suas aplicacoes', 'Biologia', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Ciencias exatas e suas aplicacoes', 'Bioquimica', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Não informado', 'Biomedicina', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Não informado', 'Farmacia', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Saude', 'Medicina Veterinaria', 12);

-- 20 INSERTs - Mariane Bedia De Andrade
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Saude', 'Medicina', 12);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Saude', 'Enfermagem', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES ('Bacharelado', 'Direito', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES (NULL, 'Administracao', 10);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES (NULL, 'Recursos Humanos', 8);
INSERT INTO cadastro.curso (descricao_curso, nome_curso, qtd_semestre) VALUES (NULL, 'Arquitetura e Urbanismo', 10);

INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Calculo I', '08.07.2022', '20.12.2022', 76, 2, 4);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Calculo II', '06.02.2023', '03.07.2023', 76, 3, 4);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Calculo III', '15.07.2023', '19.12.2023', 76, 5, 4);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Logica de programacao', '06.07.2022', '15.12.2022', 36, 3, 5);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Fisica I', '06.07.2022', '15.12.2022', 36, 9, 2);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Fisica II', '06.02.2023', '03.07.2023', 36, 19, 5);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Quimica I', '08.07.2022', '20.12.2022', 36, 18, 18);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Quimica Inorganica', '06.02.2023', '03.07.2023', 18, 9, 14);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Contratos I', '06.07.2022', '15.12.2022', 18, 24, 8);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Direito penal', '06.02.2023', '03.07.2023', 76, 9, 8);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Anatomia', '08.07.2022', '20.12.2022', 76, 10, 17);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Fisiologia', '08.07.2022', '20.12.2022', 76, 25, 9);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Microbiologia', '06.07.2022', '15.12.2022', 76, 1, 10);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Genetica', '06.07.2022', '15.12.2022', 36, 5, 10);

-- 20 INSERTs - Vitória Elisa Fernandes

INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Astrofisica', '06.07.2022', '15.12.2022', 36, 12, 20);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Astroquimica', '06.02.2023', '03.07.2023', 36, 11, 21);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Comunicacao I', '08.07.2022', '20.12.2022', 18, 7, 15);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Desenho Vetorial', '06.02.2023', '03.07.2023', 36, 7, 16);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Fundamentos da lingua Brasilera de Sinais', '06.07.2022', '15.12.2022', 36, 7, 6);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Lingua Portuguesa', '06.02.2023', '03.07.2023', 36, 4, 10);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Administracao', '08.07.2022', '20.12.2022', 76, 11, 11);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Sociologia', '08.07.2022', '20.12.2022', 36, 12, 9);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Historia Antiga', '06.07.2022', '15.12.2022', 76, 18, 23);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Recursos Humanos', '06.07.2022', '15.12.2022', 36, 14, 26);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Liguagem de programacao I', '06.07.2022', '15.12.2022', 76, 1, 5);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Modelagem 3D', '06.02.2023', '03.07.2023', 76, 12, 6);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Assistencia farmaceutica', '08.07.2022', '20.12.2022', 76, 19, 14);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Linguagem de programacao II', '06.02.2023', '03.07.2023', 76, 25, 5);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Banco de dados I', '06.07.2022', '15.12.2022', 76, 22, 1);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Banco de dados II', '06.02.2023', '03.07.2023', 76,18, 1);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Linguagem de Programacao', '06.02.2023', '03.07.2023', 76, 18, 1);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Sistemas Operacionais', '20.09.2023', '09.12.2023', 36, 18, 9);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Emprendedorismo', '06.02.2024', '25.07.2024', 18, 9, 14);
INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Sistemas Digitais', '06.02.2024', '25.07.2024', 36, 23, 14);

-- UPDATEs possivelmente necessarios nas linhas abaixo:
UPDATE cadastro.curso
SET descricao_curso = NULL
WHERE descricao_curso = 'Não informado';

-- [4] CONSULTAS
-- Alem do comando SELECT correspondente, fornecer o que se pede

-- [4.1] Listagem
-- Usar junção(ões) (JOINs), filtro(s) (WHERE), ordenação (ORDER BY)
-- Enunciado: Liste o nome dos cursos e as respectivas disciplinas vinculadas em ordem alfabetica
-- Importancia na aplicacao: O usuário ter acesso as junções da tabela
-- Usuario(s) atendido(s): Todos

SELECT nome_curso AS curso, nome_disciplina AS disciplina, nome_professor as professor
FROM cadastro.curso c LEFT JOIN cadastro.disciplina d on c.cod_curso = d.cod_curso LEFT  JOIN cadastro.professor p on d.cod_prof = p.cod_professor
ORDER BY curso ASC;


-- [4.2] Relatorio
-- Usar junção(ões) (JOINs), filtro(s) (WHERE), agrupamento (GROUP BY) e função de agregacao (count, sum, avg, etc)
-- Enunciado: Listar os professores e a quantidade de disciplina que cada um ministra
-- Importancia na aplicacao: Verificar se existe algum professor com disciplinas além do indicado.
-- Usuario(s) atendido(s): Coordenador e Diretor

SELECT nome_professor AS professor, COUNT (nome_disciplina) AS disciplina
FROM cadastro.professor p INNER JOIN  cadastro.disciplina d ON p.cod_professor=d.cod_prof INNER JOIN cadastro.curso c ON c.cod_curso = d.cod_curso
GROUP BY professor;

-- [5] VISOES


-- [5.1] Visao
-- A visao deve ter, no minimo, as caracteristicas de 4.1
-- Enunciado: Uma categoria de usuário precisa ler os cursos e matérias e professores relacionados ao mesmo em ordem alfabética 
-- Importancia na aplicação: Ter acesso mais rápido a essas informações
-- Usuario(s) atendido(s): TODOS estão permitidos a ter acesso a essa view.

CREATE VIEW cadastro.curso_disciplina_professor AS
SELECT nome_curso AS curso, nome_disciplina AS disciplina, nome_professor as professor
FROM cadastro.curso c LEFT JOIN cadastro.disciplina d on c.cod_curso = d.cod_curso LEFT JOIN cadastro.professor p on d.cod_prof = p.cod_professor
ORDER BY  curso ASC;


-- [5.2] Consulta na visao
-- Consultar a visao criada em 5.1 realizando filtro(s) (WHERE)
-- Enunciado: Consultando a view criada anteriormente para buscar as matérias que determinado professor está inscrito.
-- Importancia na aplicacao: Poder modificar o nome do professor que será consultado
-- Usuario(s) atendido(s): Apenas o super usuario e o administrador do banco de dados estão permitidos a fazer essa consulta.

SELECT disciplina
FROM cadastro.curso_disciplina_professor 
WHERE professor = 'Davi Roberto Angolinni';


-- [5.3] Visao materializada
-- A visao deve ter, no minimo, as caracteristicas de 4.2
-- Enunciado: Salvar em uma view os professores e a quantidade de disciplina que cada um ministra
-- Importancia na aplicacao: Conseguir acessar mais facilmente a quantidade de disciplina de cada professor
-- Usuario(s) atendido(s): Coordenador e Diretor

CREATE MATERIALIZED VIEW cadastro.mv_professor_qtddisc(p_nome, d_qtd) AS
SELECT nome_professor, COUNT (nome_disciplina)
FROM cadastro.professor p INNER JOIN  cadastro.disciplina d ON p.cod_professor=d.cod_prof INNER JOIN cadastro.curso c ON c.cod_curso = d.cod_curso
GROUP BY nome_professor;

-- [5.4] Consulta na visao materializada
-- Consultar a visao criada em 4.2 realizando filtro(s) (WHERE)
-- Enunciado:  Consultando a view criada anteriormente para buscar a quantidade de  matérias que determinado professor está inscrito.
-- Importancia na aplicacao: Ver um professor especifico sem precisar ficar olhando uma tabela inteira
-- Usuario(s) atendido(s): Coordenador e Diretor

SELECT p_nome, d_qtd
FROM cadastro.mv_professor_qtddisc
WHERE p_nome = 'Felipe Siqueira Neto';


-- [5.5] Atualizacao da visao materializada
-- Comente brevemente sobre a necessidade de atualização e qual seria a frequencia/periodicidade
-- é necessário fazer um refresh na visao materializada cada vez que uma disciplina é adicionada para que a quantidade de materia aumente para o professor que irá ministrar
-- Redija o comando REFRESH correspondente

INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Compiladores', '06.07.2022', '15.12.2022', 78, 22, 1);

REFRESH MATERIALIZED VIEW cadastro.mv_professor_qtddisc;

-- [6] DESEMPENHO DO PROCESSAMENTO DAS CONSULTAS
-- Primeiro analise o desempenho das suas consultas 4.1., 4.2, 5.2 e 5.4, verificando custo e tempo das operacoes
-- Depois de analisa-las, comente a necessidade da criacao ou nao de um indice e justifique a escolha pelo tipo de indice.
-- Selecione uma dentre essas consultas (a mais importante delas) e apresente aquilo que se pede abaixo.

-- [6.1] EXPLAIN 
-- comente com '--' as linhas do plano abaixo e apague esta linha

/*                                    QUERY PLAN
-----------------------------------------------------------------------------------
 Sort  (cost=52.59..53.34 rows=300 width=812)
   Sort Key: c.nome_curso
   ->  Hash Left Join  (cost=25.63..40.24 rows=300 width=812)
         Hash Cond: (d.cod_prof = p.cod_professor)
         ->  Hash Right Join  (cost=11.57..25.38 rows=300 width=416)
               Hash Cond: (d.cod_curso = c.cod_curso)
               ->  Seq Scan on disciplina d  (cost=0.00..13.00 rows=300 width=220)
               ->  Hash  (cost=10.70..10.70 rows=70 width=208)
                     ->  Seq Scan on curso c  (cost=0.00..10.70 rows=70 width=208)
         ->  Hash  (cost=11.80..11.80 rows=180 width=408)
               ->  Seq Scan on professor p  (cost=0.00..11.80 rows=180 width=408)
(11 rows)

depois dos index
                                    QUERY PLAN
----------------------------------------------------------------------------------
 Sort  (cost=6.89..6.98 rows=34 width=812)
   Sort Key: c.nome_curso
   ->  Hash Left Join  (cost=4.48..6.03 rows=34 width=812)
         Hash Cond: (d.cod_prof = p.cod_professor)
         ->  Hash Right Join  (cost=2.74..4.18 rows=34 width=416)
               Hash Cond: (d.cod_curso = c.cod_curso)
               ->  Seq Scan on disciplina d  (cost=0.00..1.34 rows=34 width=220)
               ->  Hash  (cost=2.33..2.33 rows=33 width=208)
                     ->  Seq Scan on curso c  (cost=0.00..2.33 rows=33 width=208)
         ->  Hash  (cost=1.33..1.33 rows=33 width=408)
               ->  Seq Scan on professor p  (cost=0.00..1.33 rows=33 width=408)
(11 rows)

*/

-- [6.2] EXPLAIN ANALYZE

/*                                                      QUERY PLAN                                                    
------------------------------------------------------------------------------------------------------------------------------
 Sort  (cost=52.59..53.34 rows=300 width=812) (actual time=0.525..0.530 rows=49 loops=1)
   Sort Key: c.nome_curso
   Sort Method: quicksort  Memory: 36kB
   ->  Hash Left Join  (cost=25.63..40.24 rows=300 width=812) (actual time=0.154..0.202 rows=49 loops=1)
         Hash Cond: (d.cod_prof = p.cod_professor)
         ->  Hash Right Join  (cost=11.57..25.38 rows=300 width=416) (actual time=0.105..0.138 rows=49 loops=1)
               Hash Cond: (d.cod_curso = c.cod_curso)
               ->  Seq Scan on disciplina d  (cost=0.00..13.00 rows=300 width=220) (actual time=0.011..0.015 rows=34 loops=1)
               ->  Hash  (cost=10.70..10.70 rows=70 width=208) (actual time=0.063..0.063 rows=33 loops=1)
                     Buckets: 1024  Batches: 1  Memory Usage: 11kB
                     ->  Seq Scan on curso c  (cost=0.00..10.70 rows=70 width=208) (actual time=0.025..0.040 rows=33 loops=1)
         ->  Hash  (cost=11.80..11.80 rows=180 width=408) (actual time=0.035..0.035 rows=33 loops=1)
               Buckets: 1024  Batches: 1  Memory Usage: 13kB
               ->  Seq Scan on professor p  (cost=0.00..11.80 rows=180 width=408) (actual time=0.013..0.018 rows=33 loops=1)
 Planning Time: 0.370 ms
 Execution Time: 0.627 ms
(16 rows)

Após os index

                                                         QUERY PLAN                                                     
-----------------------------------------------------------------------------------------------------------------------------
 Sort  (cost=6.89..6.98 rows=34 width=812) (actual time=0.399..0.405 rows=49 loops=1)
   Sort Key: c.nome_curso
   Sort Method: quicksort  Memory: 36kB
   ->  Hash Left Join  (cost=4.48..6.03 rows=34 width=812) (actual time=0.147..0.192 rows=49 loops=1)
         Hash Cond: (d.cod_prof = p.cod_professor)
         ->  Hash Right Join  (cost=2.74..4.18 rows=34 width=416) (actual time=0.100..0.129 rows=49 loops=1)
               Hash Cond: (d.cod_curso = c.cod_curso)
               ->  Seq Scan on disciplina d  (cost=0.00..1.34 rows=34 width=220) (actual time=0.009..0.013 rows=34 loops=1)
               ->  Hash  (cost=2.33..2.33 rows=33 width=208) (actual time=0.058..0.059 rows=33 loops=1)
                     Buckets: 1024  Batches: 1  Memory Usage: 11kB
                     ->  Seq Scan on curso c  (cost=0.00..2.33 rows=33 width=208) (actual time=0.030..0.041 rows=33 loops=1)
         ->  Hash  (cost=1.33..1.33 rows=33 width=408) (actual time=0.029..0.029 rows=33 loops=1)
               Buckets: 1024  Batches: 1  Memory Usage: 13kB
               ->  Seq Scan on professor p  (cost=0.00..1.33 rows=33 width=408) (actual time=0.010..0.016 rows=33 loops=1)
 Planning Time: 0.402 ms
 Execution Time: 0.495 ms
(16 rows)
*/

-- [6.3] Comentarios e justificativas para o indice 
-- Considerar custo e tempo das operacoes, por exemplo

/*O SELECT utilizava as tabelas disciplina, curso e professor. Como são muitas tabelas com muitas colunas, o index facilitou a busca pelas colunas que serão utilizadas no resultado: nome_disciplina, nome_curso e nome_professor, assim, diminuindo os custos e tempo de cada etapa. */

-- [6.4] CREATE INDEX e PARAMETROS (Set)
-- Crie o indice, verifique se o indice ja esta sendo usado no processamento da consulta e, caso nao esteja, ajuste os parametros

CREATE INDEX  disciplinas
ON cadastro.disciplina(nome_disciplina);

CREATE INDEX  cursos
ON cadastro.curso (nome_curso);

CREATE INDEX professores
ON cadastro.professor (nome_professor);

-- [7] FUNCOES INTERNAS
-- Usar funcoes internas nas operacoes em tabelas do banco de dados

-- Explicar aqui o que o comando abaixo faz e sua utilidade na aplicacao
-- Calcular a quantidade de semestres em cada curso, para ver a média de semestres nos cursos de determinada descricao

SELECT SUM(qtd_semestre) AS total_semestre
FROM cadastro.curso c
WHERE descricao_curso = 'Licenciatura';

-- Explicar aqui o que o comando abaixo faz e sua utilidade na aplicacao
-- Insere uma nova disciplina com a data de início sendo a data atual, para disciplinas cadastradas no mesmo dia que inicia

INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Matematica Basica', current_date, current_date+30, 60, 2, 5);


-- Explicar aqui o que o comando abaixo faz e sua utilidade na aplicacao
-- Atualizar a disciplina com código 4 para modificar a data. Caso exista atraso para iniciar uma matéria, pode ser colocado a data atual

UPDATE cadastro.disciplina
SET qtd_aulas = qtd_aulas - 10
WHERE EXTRACT(MONTH FROM data_inicio) = 02;

-- Explicar aqui o que o comando abaixo faz e sua utilidade na aplicacao
-- Deletar todas as disciplinas que possuem o maior número de aulas, pode ser utilizada para deletar as materias com quantidades de aula acima do indicado

DELETE FROM cadastro.disciplina 
WHERE qtd_aulas = (SELECT MAX (qtd_aulas) 
FROM cadastro.disciplina);

-- [8] USER-DEFINED FUNCTION (UDF)
-- Vislumbrar a criação de uma função (UDF) para o banco de dados.
-- Comentar a utilidade da funcao na aplicacao.

-- Redigir o comando CREATE OR REPLACE FUNCTION correspondente usando PL/pgSQL.
-- Redigir um comando SQL que chame a funcao, explicando o que sua chamada faz.
-- A funcao devera' ter parametro(s).

-- Comentar aqui a utilidade da funcao na aplicacao 
-- A função retorna os dados dos professores que fazem aniversario no mes determinado pelo usuario

CREATE OR REPLACE FUNCTION rotinas.aniversariantes_do_mes(mes character)
RETURNS TABLE (codigo int, nome char, nasc date) AS $$
DECLARE
	num_mes int;
BEGIN
	IF LOWER(mes) IN ('janeiro') THEN
		num_mes=1;
	ELSIF LOWER(mes) IN ('fevereiro') THEN
		num_mes=2;
	ELSIF LOWER(mes) IN ('março') THEN
		num_mes=3;
	ELSIF LOWER(mes) IN ('abril') THEN
		num_mes=4;
	ELSIF LOWER(mes) IN ('maio') THEN
		num_mes=5;
	ELSIF LOWER(mes) IN ('junho') THEN
		num_mes=6;	
	ELSIF LOWER(mes) IN ('julho') THEN
		num_mes=7;
	ELSIF LOWER(mes) IN ('agosto') THEN
		num_mes=8;	
	ELSIF LOWER(mes) IN ('setembro') THEN
		num_mes=9;
	ELSIF LOWER(mes) IN ('outubro') THEN
		num_mes=10;
	ELSIF LOWER(mes) IN ('novembro') THEN
		num_mes=11;
	ELSIF LOWER(mes) IN ('dezembro') THEN
		num_mes=12
	ELSE;
		RAISE NOTICE 'Mes inválido';		
	END IF;

	RETURN QUERY 
	SELECT cod_professor, nome_professor, data_nasc 
	FROM cadastro.professor
	WHERE EXTRACT(MONTH FROM data_nasc) = num_mes
	ORDER BY EXTRACT(DAY FROM data_nasc) ASC;
END;
$$ LANGUAGE 'plpgsql';


-- Explicar aqui o que a chamada abaixo faz
-- No select é possível selecionar o mes que sera utilizado na funcao
SELECT * FROM rotinas.aniversariantes_do_mes('Janeiro');

-- [9] STORED PROCEDURE
-- Vislumbrar a criação de um procedimento armazenado para o banco de dados.
-- Comentar a utilidade do procedimento na aplicacao.
-- Redigir o comando CREATE OR REPLACE PROCEDURE correspondente usando PL/pgSQL.
-- Redigir um comando SQL que chame o procedimento, explicando o que sua chamada faz.
-- O procedimento deverá ter parametro(s). 

-- Comentar a utilidade do procedimento na aplicacao.
/*Os diretores e coordenadores podem utilizar esse procedimento para verificar a disponibilidade de um determinado professor para realizar mais atividades como ministrar uma nova disciplina, por exemplo. O procedimento também mostra se o professor está sobrecarregado, ou seja, se já atingiu ou ultrapassou a quantidade máxima de aulas.
*/

CREATE OR REPLACE PROCEDURE rotinas.verifica_disponibilidade_prof(codigo_prof int) AS $$
DECLARE
	prof cadastro.professor%ROWTYPE;
	qtd_aulas_prof int := 0;
BEGIN
	SELECT SUM(qtd_aulas) INTO qtd_aulas_prof FROM cadastro.disciplina
	WHERE cod_prof=codigo_prof;
	
	SELECT * INTO prof FROM cadastro.professor 
	WHERE cod_professor = codigo_prof;
	
	IF qtd_aulas_prof>200 THEN
		RAISE NOTICE 'Professor % ultrapassou a quantidade máxima de aulas.', prof.nome_professor;
	ELSIF qtd_aulas_prof=200 THEN
		RAISE NOTICE 'Professor % atingiu a quantidade máxima de aulas.', prof.nome_professor;
	ELSE
		RAISE NOTICE 'Professor % ainda disponível para mais atividades. Quantidade de aulas: %', prof.nome_professor, qtd_aulas_prof;
	END IF;
END;
$$ LANGUAGE 'plpgsql';


-- Explicar aqui o que a chamada abaixo faz

--Essa chamada mostra na tela a mensagem informando se o professor cujo código é 33 atingiu a quantidade máxima de aulas, --ultrapassou o limite, ou ainda tem horários disponíveis para realizar outras atividades ou ministrar mais aulas.

CALL rotinas.verifica_disponibilidade_prof(12); 


-- [10] TRIGGER
-- Revisar as aplicações em potencial para bancos de dados ativos (e gatilhos).
-- Vislumbrar a criação de um gatilho e de uma função engatilhada para o banco de dados.
-- Se necessário redigir logo abaixo outros comandos SQL necessários (criacao de coluna, atualização de tuplas etc):

-- [10.1] ROW
-- Comentar aqui a utilidade, para a aplicação, do gatilho em nível de tupla e da sua função engatilhada.
-- Cada vez que for inserir uma nova disciplina, pegará o codigo do professor e aumentará seu salario em 10%.

-- Redigir o comando CREATE OR REPLACE FUNCTION correspondente usando PL/pgSQL

CREATE OR REPLACE FUNCTION rotinas.tf_aumenta_salario()
RETURNS TRIGGER AS $$
BEGIN
	IF (TG_OP = 'INSERT') THEN
		UPDATE cadastro.professor
		SET salario = salario + (salario * 0.10)
		WHERE cod_professor = NEW.cod_prof;
	RETURN NEW;
	ELSIF (TG_OP = 'UPDATE') THEN
		UPDATE cadastro.professor
		SET salario = salario + (salario * 0.10)
		WHERE cod_professor = NEW.cod_prof;
		UPDATE cadastro.professor
		SET salario = salario - (salario * 0.10)
		WHERE cod_professor = OLD.cod_prof;
		RETURN NEW;
	ELSIF (TG_OP = 'DELETE') THEN
		UPDATE cadastro.professor
		SET salario = salario - (salario * 0.10)
		WHERE cod_professor = OLD.cod_prof;
		RETURN OLD;
	END IF;
	RETURN NULL;
END;
$$ LANGUAGE 'plpgsql';

-- Redigir o comando CREATE TRIGGER correspondente ao gatilho em nivel de tupla usando PL/pgSQL

CREATE  OR REPLACE TRIGGER t_aumenta_salario
AFTER INSERT OR DELETE OR UPDATE ON cadastro.disciplina
FOR EACH ROW EXECUTE FUNCTION rotinas.tf_aumenta_salario();
-- Redigir pelo menos 1 comando SQL que dispare o gatilho em nivel de tupla
-- Descrever o que acontece no banco de dados quando e' disparado
-- Ao fazer essa inserção de dados o salário do professor de código 1 vai aumentar o salário em 10%

INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Lógica de Programação', '06.02.2024', '25.07.2024', 38, 1, 14);

-- Se necessário para executar os comandos seguintes, remover o gatilho de 10.1 abaixo:

DROP TRIGGER IF EXISTS t_aumenta_salario on cadastro.disciplina;

-- Inserir uma nova coluna para a tabela curso
ALTER TABLE cadastro.curso
ADD qtd_disc BIGINT;


-- [10.2] STATEMENT
-- Comentar aqui a utilidade, para a aplicação, do gatilho em nível de sentença e da sua função engatilhada.
-- O gatilho abaixo tem função de calcular a quantidade de matéria em cada curso e atualizar a coluna qtd_disc na tabela curso.
-- Redigir o comando CREATE OR REPLACE FUNCTION correspondente usando PL/pgSQL

CREATE OR REPLACE FUNCTION rotinas.tf_calcula_disciplina_statement()
RETURNS TRIGGER AS $$
BEGIN
	UPDATE cadastro.curso c
	SET qtd_disc = (SELECT COUNT(d.nome_disciplina) 
	FROM cadastro.disciplina d  
	WHERE c.cod_curso = d.cod_curso);
	RETURN NEW;
END;
$$ LANGUAGE 'plpgsql';

-- Redigir o comando CREATE TRIGGER correspondente ao gatilho em nível de sentenca usando PL/pgSQL

CREATE  OR REPLACE TRIGGER t_calcula_disciplina
AFTER INSERT OR DELETE OR UPDATE ON cadastro.disciplina
FOR EACH STATEMENT EXECUTE FUNCTION rotinas.tf_calcula_disciplina_statement();

-- Redigir pelo menos 1 comando SQL que dispare o gatilho em nível de sentenca

INSERT INTO cadastro.disciplina (nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso) 
VALUES ('Linguagens Formais', '08.07.2022', '20.12.2022', 76, 2, 1);

-- Descrever o que acontece no banco de dados quando e' disparado
-- Ao disparar o gatilho em sentença ele vai calcular quantas disciplinas tem cada curso e preencher toda a coluna qtd_disc da tabela cursos com seus respectivos valores.

 -- [11] SEGURANCA

-- [11.1] ACESSO REMOTO (pg_hba.conf)
-- Cole nas linhas abaixo o conteudo do arquivo pg_hba.conf que o servidor deve conter, iniciando cada linha com comentario '--' (para nao impedir a execucao desse script); 

/* 
# TYPE  DATABASE        USER            ADDRESS                 METHOD

# "local" is for Unix domain socket connections only
local   all             	all                                     		scram-sha-256
# IPv4 local connections:
host    all             	all             		127.0.0.1/32            scram-sha-256
host 	cadastrodisc 		dbadm				10.128.70.0/24		scram-sha-256
host 	cadastrodisc		diretor				10.128.70.0/24		scram-sha-256
host 	cadastrodisc		coordenador			10.128.70.0/24		scram-sha-256
host 	cadastrodisc		professor			10.128.70.0/24		scram-sha-256
*/

-- [11.2] PAPEIS (Roles)
-- Criar papeis de usuarios e de grupos
-- Nessa criacao, considerar tanto papeis da equipe (administracao/desenvolvimento) quanto papeis de usuarios da aplicacao
-- Para cada papel criado adicionar um comentario antes explicando qual e' a utilidade dele na aplicacao

CREATE ROLE dbadm;
ALTER ROLE dbadm WITH NOSUPERUSER INHERIT CREATEROLE NOCREATEDB LOGIN NOREPLICATION NOBYPASSRLS PASSWORD 'cadastro123';

CREATE ROLE diretor;
ALTER ROLE diretor WITH NOSUPERUSER INHERIT CREATEROLE NOCREATEDB LOGIN NOREPLICATION NOBYPASSRLS PASSWORD 'cadastro123';


CREATE ROLE coordenador;
ALTER ROLE coordenador WITH NOSUPERUSER INHERIT NOCREATEROLE NOCREATEDB LOGIN NOREPLICATION NOBYPASSRLS PASSWORD 'cadastro123';

CREATE ROLE professor;
ALTER ROLE professor WITH NOSUPERUSER INHERIT NOCREATEROLE NOCREATEDB LOGIN NOREPLICATION NOBYPASSRLS PASSWORD 'cadastro123';

-- [11.3] PRIVILEGIOS DE ACESSO (Grant)

-- [11.3.1]
-- Assegurar os privilegios necessarios para o(s) papel(is) poder(em) criar o(s) esquema(s) da Secao 1
-- Usuario(s) podem conceder esse acesso alem do superusuario: diretor

GRANT USAGE ON SCHEMA cadastro TO diretor,coordenador,professor,dbadm;
GRANT USAGE ON SCHEMA rotinas TO diretor,coordenador,dbadm, professor;

GRANT CREATE ON database cadastrodisci TO diretor;
-- [11.3.2]
-- Assegurar os privilegios necessarios para o(s) papel(is) poder(em) criar a(s) tabela(s), as sequencias e as restricoes da Secao 2 e as visoes da Secao 5
-- Usuario(s) podem conceder esse acesso alem do superusuario: diretor

GRANT CREATE ON SCHEMA cadastro TO diretor;
GRANT CREATE ON SCHEMA rotinas TO diretor;

-- [11.3.3]
-- Assegurar os privilegios necessarios para o(s) papel(is) poder(em) inserir e atualizar tuplas, conforme a Secao 3
-- Usuario(s) podem conceder esse acesso alem do superusuario: diretor, coordenador
GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA cadastro to coordenador;
GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA cadastro to diretor;
GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA cadastro to professor;

GRANT UPDATE, INSERT, DELETE ON cadastro.curso TO diretor WITH GRANT OPTION;
GRANT UPDATE, INSERT, DELETE ON cadastro.professor TO diretor WITH GRANT OPTION;
GRANT UPDATE, INSERT, DELETE ON cadastro.disciplina TO coordenador, diretor;
GRANT UPDATE, INSERT, DELETE ON cadastro.professor TO coordenador;
GRANT INSERT, DELETE ON cadastro.professor TO professor;
GRANT UPDATE (nome_professor, data_nasc) ON cadastro.professor TO professor;


-- [11.3.4]
-- Assegurar os privilegios necessarios para o(s) papel(is) poder(em) executar as consultas das Secoes 4 e 5
-- Usuario(s) podem conceder esse acesso alem do superusuario: diretor

GRANT SELECT ON cadastro.curso, cadastro.disciplina, cadastro.professor TO diretor WITH GRANT OPTION;
GRANT SELECT ON cadastro.curso, cadastro.disciplina, cadastro.professor TO coordenador;
GRANT SELECT ON cadastro.curso, cadastro.disciplina, cadastro.professor TO professor;

GRANT SELECT ON cadastro.curso_disciplina_professor TO coordenador, professor, diretor, dbadm;

GRANT SELECT ON cadastro.mv_professor_qtddisc TO coordenador, dbadm, diretor;

-- [11.3.5]
-- Assegurar os privilegios necessarios para o(s) papel(is) poder(em) executar os comandos da Secao 7
-- Usuario(s) podem conceder esse acesso alem do superusuario: citar aqui
-- Apagar essa linha e adicionar os comandos necessarios
GRANT SELECT ON cadastro.curso TO diretor WITH GRANT OPTION;
GRANT SELECT, UPDATE, DELETE ON cadastro.disciplina TO diretor;
GRANT UPDATE ON cadastro.disciplina TO coordenador;


-- [11.3.6]
-- Assegurar os privilegios necessarios para o(s) papel(is) poder(em) executar as subrotinas das Secoes 8, 9 e 10
-- Assegurar tambem os privilegios para executar os comandos que realizam as chamadas (ou disparos) daquelas subrotinas
-- Usuario(s) podem conceder esse acesso alem do superusuario: coordenador, diretor

GRANT EXECUTE ON FUNCTION rotinas.aniversariantes_do_mes TO coordenador;
GRANT EXECUTE ON FUNCTION rotinas.aniversariantes_do_mes TO professor;

GRANT EXECUTE ON PROCEDURE rotinas.verifica_disponibilidade_prof TO coordenador; 

GRANT UPDATE ON cadastro.curso TO coordenador;

-- [11.4] PRIVILEGIOS DE ACESSO (Revoke)

-- [11.4.1]
-- Revogar o acesso em 11.3.1 de pelo menos 1 papel
-- Usuario(s) podem revogar esse acesso alem do superusuario: apenas o superusuario

REVOKE CREATE ON database cadastrodisci FROM diretor;
REVOKE USAGE ON SCHEMA rotinas FROM professor;

-- [11.4.2]
-- Revogar o acesso em 11.3.2 de pelo menos 1 papel
-- Usuario(s) podem revogar esse acesso alem do superusuario: apenas o superusuario

REVOKE CREATE ON SCHEMA cadastro FROM diretor; 


-- [11.4.3]
-- Revogar o acesso em 11.3.3 de pelo menos 1 papel
-- Usuario(s) podem revogar esse acesso alem do superusuario: diretor

REVOKE UPDATE ON cadastro.professor FROM coordenador;

-- [11.4.4]
-- Revogar o acesso em 11.3.4 de pelo menos 1 papel
-- Usuario(s) podem revogar esse acesso alem do superusuario: diretor

REVOKE SELECT ON cadastro.curso, cadastro.disciplina, cadastro.professor FROM professor;

-- [11.4.5]
-- Revogar o acesso em 11.3.5 de pelo menos 1 papel
-- Usuario(s) podem revogar esse acesso alem do superusuario: diretor

REVOKE UPDATE ON cadastro.disciplina FROM coordenador;

-- [11.4.6]
-- Revogar o acesso em 11.3.6 de pelo menos 1 papel
-- Usuario(s) podem revogar esse acesso alem do superusuario: diretor

REVOKE EXECUTE ON PROCEDURE rotinas.verifica_disponibilidade_prof FROM coordenador; 

REVOKE USAGE ON SCHEMA rotinas FROM professor;


-- Se for necessario para executar os comandos seguintes, assegure novamente os privilegios de acesso revogados acima

GRANT CREATE ON database cadastrodisci TO diretor;
GRANT CREATE ON SCHEMA cadastro TO diretor;
GRANT UPDATE ON cadastro.professor TO coordenador;
GRANT SELECT ON cadastro.curso, cadastro.disciplina, cadastro.professor TO professor;
GRANT UPDATE ON cadastro.disciplina TO coordenador;
GRANT EXECUTE ON PROCEDURE rotinas.verifica_disponibilidade_prof TO coordenador; 





