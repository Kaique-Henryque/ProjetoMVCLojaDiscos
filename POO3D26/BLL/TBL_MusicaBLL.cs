using POO3D26.DAL;
using POO3D26.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POO3D26.BLL
{
    public class TBL_MusicaBLL
    {
        private DALMysql dalBanco = new DALMysql();

        public DataTable ListarMusicas()
        {
            string sql = string.Format($@"Select * from TBl_Musica");
            return dalBanco.executarConsulta(sql);
        }

        public void AdicionarMusica(TBL_MusicaDTO dtoMusica)
        {
            string sql = string.Format($@"INSERT INTO TBL_Musica VALUES(NULL,'{dtoMusica.Nome}',
                                                                        '{dtoMusica.NomeAutor}',
                                                                        '{dtoMusica.IdGravadora}',
                                                                        '{dtoMusica.IdCD}');");
            dalBanco.executarComando(sql);
        }

        public DataTable PesquisarMusica(string busca)
        {
            string sql = string.Format($@"select * from tbl_musica where nome like '%{busca}%'");
            return dalBanco.executarConsulta(sql);
        }

        public void AlterarMusica(TBL_MusicaDTO dtoMusica)
        {
            string sql = string.Format($@"update tbl_musica set nome = '{dtoMusica.Nome}',
                                                                nomeAutor = '{dtoMusica.NomeAutor}',
                                                                idgravadora = '{dtoMusica.IdGravadora}',
                                                                idCD = '{dtoMusica.IdCD}' 
                                                          where idmusica = '{dtoMusica.IdMusica}';");
            dalBanco.executarComando(sql);
        }

        public void DeletarMusica(TBL_MusicaDTO dtoMusica)
        {
            string sql = string.Format($@"delete from tbl_musica where idmusica = '{dtoMusica.IdMusica}';");
            dalBanco.executarComando(sql);
        }
    }
}