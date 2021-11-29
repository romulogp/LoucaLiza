﻿using Loucaliza.model.veiculo;
using System;
using System.Collections.Generic;

namespace LoucaLiza.repository
{
    public class VeiculoRepository : IRepository<Veiculo>
    {
        public void Delete(Veiculo Entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Veiculo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Veiculo GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Veiculo Save(Veiculo veiculo)
        {
            if (veiculo == null)
            {
                return null;
            }

            if (veiculo.Id == null)
            {
                veiculo.Id = Application.Database.GenerateId();
                Application.Database.Veiculos.Add(veiculo);
            }
            else
            {
                Application.Database.Veiculos[Application.Database.Veiculos.IndexOf(veiculo)] = veiculo;
            }

            return veiculo;
        }
    }
}