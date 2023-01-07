using Carro.Dominio;
using System.Collections.Generic;

namespace Carro.Negocio
{
    public interface ICarroBusiness
    {
        List<Veiculo> Get();

        Veiculo GetVeiculo(int id);

        void Insert(Veiculo veiculo);

        Veiculo Update(Veiculo veiculo);

        void delete(int id);
    }

}
