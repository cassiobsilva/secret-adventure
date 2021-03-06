﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using secret_adventure.Models.Base;
using System.Drawing;
using secret_adventure.Models.Manager;

namespace secret_adventure.Tests
{
    [TestClass]
    public class MosquitoMachoTest
    {
        [TestMethod]
        public void MosquitoDeveSeMover()
        {
            Point posicaoOriginal = new Point(1,1);
            Point novaPosicao = new Point(1,2);
            MosquitoMacho mosquito = new MosquitoMacho(posicaoOriginal);
            MosquitoMachoManager manager = new MosquitoMachoManager(mosquito);

            manager.Mover(novaPosicao);

            Assert.AreNotEqual(mosquito.Posicao, posicaoOriginal);
        }

        [TestMethod]
        public void MosquitoDeveMorrer()
        {
            MosquitoMacho mosquito = new MosquitoMacho(new Point(1, 2));
            MosquitoMachoManager manager = new MosquitoMachoManager(mosquito);

            manager.Morrer();

            Assert.IsFalse(mosquito.Ativo);
        }

        [TestMethod]
        public void MosquitoDeveFicarMaisVelho()
        {
            MosquitoMacho mosquito = new MosquitoMacho(new Point(1, 2));
            MosquitoMachoManager manager = new MosquitoMachoManager(mosquito);
            int rodadasAntes = mosquito.TempoDeVida;

            manager.Envelhecer();

            Assert.IsTrue(rodadasAntes > mosquito.TempoDeVida);
        }
    }
}
