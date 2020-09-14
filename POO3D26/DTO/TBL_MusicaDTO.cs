using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D26.DTO
{
    public class TBL_MusicaDTO
    {
        private int idMusica, idGravadora, idCD;
        private string nome, nomeAutor;

        public int IdMusica
        {
            set
            {
                if(value != 0)
                {
                    this.idMusica = value;
                }
                else
                {
                    throw new Exception("O Id da música é obrigatório");
                }
            }
            get { return this.idMusica; }
        }

        public int IdGravadora
        {
            set
            {
                if (value != 0)
                {
                    this.idGravadora = value;
                }
                else
                {
                    throw new Exception("O Id da gravadora é obrigatório");
                }
            }
            get { return this.idGravadora; }
        }

        public int IdCD
        {
            set
            {
                if (value != 0)
                {
                    this.idCD = value;
                }
                else
                {
                    throw new Exception("O Id do CD é obrigatório");
                }
            }
            get { return this.idCD; }
        }

        public string Nome {

            set
            {
                if(value != "")
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome da música é obrigatório");
                }
            }
            get { return this.nome; }

        }

        public string NomeAutor
        {
            set
            {
                if(value != "")
                {
                    this.nomeAutor = value;
                }else
                {
                    throw new Exception("O nome do autor da música é obrigatório");
                }
            }
            get { return this.nomeAutor; }
        }
    }
}