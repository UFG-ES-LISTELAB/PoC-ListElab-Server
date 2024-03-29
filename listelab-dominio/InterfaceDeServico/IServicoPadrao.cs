﻿using System;
using System.Collections.Generic;
using System.Text;

namespace listelab_dominio.InterfaceDeServico
{
    public interface IServicoPadrao<T>
    {
        /// <summary>
        /// Cadastra um objeto de tipo genérico.
        /// </summary>
        /// <param name="objeto">Objeto a ser cadastrado.</param>
        void Cadastre(T objeto);

        /// <summary>
        /// Atualiza um objeto genérico no banco.
        /// </summary>
        /// <param name="objeto">Objeto a ser atualizado.</param>
        void Atualize(T objeto);

        /// <summary>
        /// Exclua todos os objetos que atendem determinada condição.
        /// </summary>
        /// <param name="codigo">O código que será usado como filtro.</param>
        void Exclua(int codigo);

        /// <summary>
        /// Consulta o primeiro objeto genérico que atende uma condição.
        /// </summary>
        /// <param name="codigo">O código que será usado como filtro.</param>
        /// <returns></returns>
        T Consulte(int codigo);

        /// <summary>
        /// Consulta todos os objetos que obedecem uma condição.
        /// </summary>
        /// <returns>Retorna uma coleção de objetos genéricos.</returns>
        IList<T> ConsulteLista();
    }
}
