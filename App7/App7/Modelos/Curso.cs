﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Curso
    {
        // lista de disciplinas
        private List<Disciplina> disciplinas = new List<Disciplina>();

        public List<Disciplina> Disciplinas
        {
            get
            {
                return this.disciplinas;
            }
            set
            {
                this.disciplinas = value;
            }
        }

        // atributo nome
        private String nome;

        public String Nome
        {

            get
            {
                return this.nome;
            }

        }

        // construtor da classe
        public Curso(String nome)
        {
            this.nome = nome;
        }

    }
}
