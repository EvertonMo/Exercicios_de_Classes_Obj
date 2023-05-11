using System;
using System.Collections.Generic;
using MeuTrabalho.Casa;
using MeuTrabalho.Quarto;
using MeuTrabalho.ComodoDeVisita;

namespace MeuTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            var quarto1 = new MeuQuarto() //Cntrl + Espaço para consultar as classes
            {
                MinhaCama = new Cama()
                {
                    TipoCama = new Tipo()
                    {
                        Nome = "Solteiro"
                    }
                },
                MeuGuardaRoupa = new GuardaRoupa()
                {
                    MarcaGuardaRoupa = new Marca()
                    {
                        Nome = "Casas Móveis"
                    },
                    TipoGuardaRoupa = new Tipo()
                    {
                        Nome = "Casal"
                    }
                },
                MeuVentilador = new Ventilador()
                {
                    Marca = new Marca()
                    {
                        Nome = "Consul"
                    }
                }
            };

            var quarto2 = new MeuQuarto()
            {
                MeuGuardaRoupa = new GuardaRoupa()
                {
                    MarcaGuardaRoupa = new Marca()
                    {
                        Nome = "Kappesberg"
                    },
                    TipoGuardaRoupa = new Tipo()
                    {
                        Nome = "Solteiro"
                    }
                },
                MeuVentilador = new Ventilador()
                {
                    Marca = new Marca()
                    {
                        Nome = "Cadense"
                    }
                },
                MinhaCama = new Cama()
                {
                    TipoCama = new Tipo()
                    {
                        Nome = "Casal"
                    }
                },
            };
            var quarto3 = new MeuQuarto()
            {
                MeuGuardaRoupa = new GuardaRoupa()
                {
                    MarcaGuardaRoupa = new Marca()
                    {
                        Nome = "Kappesberg"
                    },
                    TipoGuardaRoupa = new Tipo()
                    {
                        Nome = "Solteiro"
                    }
                },
                MeuVentilador = new Ventilador()
                {
                    Marca = new Marca()
                    {
                        Nome = "Cadense"
                    }
                },
                MinhaCama = new Cama()
                {
                    TipoCama = new Tipo()
                    {
                        Nome = "Casal"
                    }
                },
                AbajurQuarto = new Abajur()
                {
                    Nome = "Abajur do Quarto"
                },
                EscrivaninhaQuarto = new Escrivaninha()
                {
                    MarcaEscrivaninha = new Marca()
                    {
                        Nome = "Kappesberg"
                    }
                }
            };

            var salaPrincipal = new Sala()
            {
                SofaSala = new Sofa()
                {
                    TipoSofa = new Tipo()
                    {
                        Nome = "5 Lugares"
                    }
                },
                RackSala = new Rack()
                {
                    Nome = "Rack da Sala"
                },
                TapeteSala = new Tapete()
                {
                    Nome = "Tapete da Sala"
                },
                TvSala = new Televisao()
                {
                    Marca = new Marca()
                    {
                        Nome = "LGTV"
                    }
                },
                TipoSala = new Tipo()
                {
                    Nome = "Sala Principal"
                }
            };

            var minhaCasa = new MinhaCasa()
            {
                Quartos = new List<MeuQuarto>()
                {
                    quarto1,
                    quarto2,
                    quarto3
                },
                Banheiros = new List<Banheiro>()
                {
                    new Banheiro ()
                    {
                    Comodo = "Banheiro Sala"
                    }
                },
                Sala = new List<Sala>()
                {
                    salaPrincipal
                }
            };
        }
    }
}
