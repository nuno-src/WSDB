using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSDB
{
    internal class Msa
    {
        //Atributos
        private string nome;
        private string tipo;
        private int ano;
        private int episodios;
        private string imagem;
        private string descricao;



        //Construtor
        public Msa()
        {

            nome = "";
            tipo = "";
            ano = 0;
            episodios = 0;
            imagem = "";
            descricao = "";

        }
        public Msa(string nNome, string nTipo, int nAno, int nEpisodios, string nImagem, string nDescricao)
        {

            nome = nNome;
            tipo = nTipo;
            ano = nAno;
            episodios = nEpisodios;
            imagem = nImagem;
            descricao = nDescricao;

        }


        //Métodos
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nNome)
        {
            nome = nNome;
        }

        public string GetTipo()
        {
            return tipo;
        }
        public void SetTipo(string nTipo)
        {
            tipo = nTipo;
        }

        public int GetAno()
        {
            return ano;
        }
        public void SetAno(int nAno)
        {
            ano = nAno;
        }

        public int GetEpisodios()
        {
            return episodios;
        }
        public void SetEpisodios(int nEpisodios)
        {
            episodios = nEpisodios;
        }


        public string GetImagem()
        {
            return imagem;
        }
        public void SetImagem(string nImagem)
        {
            imagem = nImagem;
        }

        public string GetDescricao()
        {
            return descricao;
        }
        public void SetDescricao(string nDescricao)
        {
            descricao = nDescricao;
        }
        
        

        public string EnviarFicheiro()
        {
            return nome + "|" + tipo + "|" + ano + "|" + episodios + "|" + imagem + "|" + descricao;
        }

        public override string ToString()
        {
            return nome + " - " + "Tipo:" + tipo + " - " + "Ano:" + ano;
        }




    }


}
