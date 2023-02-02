using PDV_Beta.DAO;
using PDV_Beta.Entity;
using PDV_Beta.Seguranca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Beta.BLL
{
    class MovSaidasBLL
    {
        public List<Operacoes> ListaOperacoes()
        {
            MovSaidasDAO DAO = new MovSaidasDAO();
            DataTable Result = new DataTable();
            Result = DAO.ListaOperacoes();
            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<Operacoes> OP = new List<Operacoes>();
                    try
                    {
                        foreach (DataRow linha in Result.Rows)
                        {
                            Operacoes operacao = new Operacoes();
                            operacao.Ativo = Convert.ToInt32(linha.ItemArray[1]);
                            operacao.Tipo = Convert.ToInt32(linha.ItemArray[2]);
                            operacao.CFOP = linha.ItemArray[3].ToString();

                            OP.Add(operacao);
                        }

                    }
                    catch (Exception) { return null; }
                    return OP;
                }
            return null;
        }
        public List<ProdutoSabor> ListaSabores(string id)
        {
            MovSaidasDAO DAO = new MovSaidasDAO();
            DataTable Result = new DataTable();
            Result = DAO.ListaSabores(id);
            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<ProdutoSabor> PRO = new List<ProdutoSabor>();
                    try
                    {
                        foreach (DataRow linha in Result.Rows)
                        {
                            ProdutoSabor pro = new ProdutoSabor();
                            pro.Id = linha.ItemArray[0].ToString();
                            pro.Nome = linha.ItemArray[1].ToString();
                            pro.Produto_Tipo = linha.ItemArray[2].ToString();

                            PRO.Add(pro);
                        }

                    }
                    catch (Exception) { return null; }
                    return PRO;
                }
            return null;
        }
        public ProdutoTipoTamanhoPreco BuscaProdutoTipoTamanhoPreco(string tipo, string tamanho)
        {
            MovSaidasDAO DAO = new MovSaidasDAO();
            DataTable Result = new DataTable();
            Result = DAO.ListaProdutoTipoTamanhoPreco(tipo,tamanho);
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        ProdutoTipoTamanhoPreco preco = new ProdutoTipoTamanhoPreco();
                        preco.Id = Result.Rows[0].ItemArray[0].ToString();
                        preco.CodTipo = Result.Rows[0].ItemArray[1].ToString();
                        preco.CodTamanho = Result.Rows[0].ItemArray[2].ToString();
                        preco.Preco1 = Result.Rows[0].ItemArray[3].ToString();
                        preco.Preco2 = Result.Rows[0].ItemArray[4].ToString();
                        preco.Preco3 = Result.Rows[0].ItemArray[5].ToString();
                        preco.Custo = Result.Rows[0].ItemArray[6].ToString();

                        return preco;
                }
            return null;
        }

        public Produto BuscaProdutoPorCodigo(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                MovSaidasDAO DAO = new MovSaidasDAO();
                DataTable Result = new DataTable();
                Result = DAO.BuscaProdutoPorCodigo(codigo);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        {
                            return DataToEntityProduto(Result);
                        }

            }
            return null;
        }

        

        public Saida Salvar(Saida saida)
        {
            if (!string.IsNullOrEmpty(saida.Cliente))
                if (!string.IsNullOrEmpty(saida.CFOP))
                {
                    MovSaidasDAO DAO = new MovSaidasDAO();
                    DataTable Result = new DataTable();
                    saida.Caixa = Autenticacao.GetCaixa();
                    if (string.IsNullOrEmpty(saida.Vendedor))
                        saida.Vendedor = Autenticacao.GetCodUsuario().ToString();
                    if (string.IsNullOrEmpty(saida.Transportadora))
                        saida.Transportadora = null;
                    if (string.IsNullOrEmpty(saida.Observacoes))
                        saida.Observacoes = "";
                    if (string.IsNullOrEmpty(saida.NumNota))
                        saida.NumNota = "";
                    if (string.IsNullOrEmpty(saida.Mesa))
                        saida.Mesa = "";
                    if (string.IsNullOrEmpty(saida.Comanda))
                        saida.Comanda = "";
                    

                    Result = DAO.SalvaSaida(saida, Autenticacao.GetCodFilial(), Autenticacao.GetCodUsuario());
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                try { saida.Id = Result.Rows[0].ItemArray[0].ToString(); } catch { saida.Result = 2; return saida; }

                                DataTable Result2 = new DataTable();
                                foreach (Saida_Produtos pro in saida.Lista_produtos)
                                {
                                    pro.ID_Saida = saida.Id;
                                    Result2 = DAO.SalvaProduto(pro, Autenticacao.GetCodUsuario());
                                    if (Result2 == null)
                                    {
                                        saida.Result = 3;
                                        return saida;
                                    }
                                    if (Result2.Rows.Count <= 0)
                                    {
                                        saida.Result = 4;
                                        return saida;
                                    }
                                    if (Result2.Rows[0].ItemArray[0].ToString().Equals("-1"))
                                    {
                                        saida.Result = 5;
                                        return saida;
                                    }
                                }

                                saida.Result = 1;
                                return saida;
                            }
                }
            saida.Result = 0;
            return saida;
        }

        public Saida Atualizar(Saida saida)
        {
            if (!string.IsNullOrEmpty(saida.Id))
            {
                MovSaidasDAO DAO = new MovSaidasDAO();
                DataTable Result = new DataTable();
                if (string.IsNullOrEmpty(saida.Vendedor))
                    saida.Vendedor = Autenticacao.GetCodUsuario().ToString();
                if (string.IsNullOrEmpty(saida.Transportadora))
                    saida.Transportadora = null;
                Result = DAO.AtualizaSaida(saida, Autenticacao.GetCodFilial(), Autenticacao.GetCodUsuario());
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        {
                            DataTable Result2 = new DataTable();
                            Result2 = DAO.ApagaLinhas(saida.Id);
                            if (Result2 == null)
                            {
                                saida.Result = 3;
                                return saida;
                            }
                            if (Result2.Rows.Count <= 0)
                            {
                                saida.Result = 4;
                                return saida;
                            }
                            if (Result2.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                saida.Result = 5;
                                return saida;
                            }

                            DataTable Result3 = new DataTable();
                            if(saida.Lista_produtos != null)
                            foreach (Saida_Produtos pro in saida.Lista_produtos)
                            {
                                pro.ID_Saida = saida.Id;
                                Result3 = DAO.SalvaProduto(pro, Autenticacao.GetCodUsuario());
                                if (Result3 == null)
                                {
                                    saida.Result = 3;
                                    return saida;
                                }
                                if (Result3.Rows.Count <= 0)
                                {
                                    saida.Result = 4;
                                    return saida;
                                }
                                if (Result3.Rows[0].ItemArray[0].ToString().Equals("-1"))
                                {
                                    saida.Result = 5;
                                    return saida;
                                }
                            }

                            saida.Result = 1;
                            return saida;
                        }
            }
            saida.Result = 0;
            return saida;
        }

        public List<Saida> BuscaSaidas(int posicao, string codigo)
        {
            string numnota = null;
            string sequencia = null;
            string comanda = null;
            string mesa = null;
            string painel = null;

            switch (posicao)
            {
                case 1: numnota = codigo;
                    break;
                case 2: sequencia = codigo;
                    break;
                case 3: comanda = codigo;
                    break;
                case 4: mesa = codigo;
                    break;
                case 5: painel = codigo;
                    break;
            }

            MovSaidasDAO DAO = new MovSaidasDAO();
            DataTable Result = new DataTable();
            if(!string.IsNullOrEmpty(codigo))
                Result = DAO.BuscaSaidas(Autenticacao.GetCodFilial(), numnota, sequencia, comanda, mesa, painel);
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        {
                            return DataToEntitySaidas(Result);
                        }


            return null;
        }

        public List<Saida> BuscaSaidasPorData(DateTime inicio, DateTime fim)
        {
            MovSaidasDAO DAO = new MovSaidasDAO();
            DataTable Result = new DataTable();

            TimeSpan inc = new TimeSpan(23, 59, 59);

            if (inicio > fim)
                inicio = fim;

            fim = fim.Add(inc);

            Result = DAO.BuscaSaidasPorData(Autenticacao.GetCodFilial(), inicio,fim);

            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        return DataToEntitySaidas(Result);
                    }


            return null;
        }


        public List<Saida_Produtos> BuscaSaidas_Produtos(string id)
        {
            MovSaidasDAO DAO = new MovSaidasDAO();
            DataTable Result = new DataTable();


            if (string.IsNullOrEmpty(id))
                return null;
            Result = DAO.BuscaSaida_Produtos(id);

            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        return DataToEntitySaida_Produto(Result);
                    }
            return null;
        }


        public bool AtualizaFinanceiro(Saida saida)
        {
            if (saida != null)
                if (!string.IsNullOrEmpty(saida.Id))
                {
                    MovSaidasDAO DAO = new MovSaidasDAO();
                    DataTable Result = new DataTable();
                    Result = DAO.AtualizaFinanceiro(Autenticacao.GetCodUsuario(), Autenticacao.GetCodFilial(), saida.Id, Autenticacao.GetCaixa_Situacao(), saida.Recebe_Total,saida.Recebe_Dinheiro,saida.Recebe_Cartao_Convenio,saida.Recebe_cartao_Credito,saida.Recebe_Cartao_Debito);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                                return true;
                }                             
            return false;
        }


        public bool CancelaNota(Saida saida)
        {
            if (saida != null)
                if (!string.IsNullOrEmpty(saida.Id))
                    if (saida.Nota_cancelada != 1)
                        if (saida.Efetivada_Financ != 0)
                        {
                            MovSaidasDAO DAO = new MovSaidasDAO();
                            DataTable Result = new DataTable();
                            Result = DAO.CancelaNota(Autenticacao.GetCodUsuario(), Autenticacao.GetCodFilial(), saida.Id, Autenticacao.GetCaixa_Situacao(), saida.Recebe_Total, saida.Motivo_cancelamento,saida.Recebe_Dinheiro,saida.Recebe_Cartao_Convenio,saida.Recebe_cartao_Credito,saida.Recebe_Cartao_Debito);
                            if (Result != null)
                                if (Result.Rows.Count > 0)
                                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                                        return true;
                        }
            return false;
        }


        public bool AtualizaEstoque(Saida saida)
        {
            MovSaidasDAO DAO = new MovSaidasDAO();
            DataTable Result = new DataTable();

            if(saida.Lista_produtos != null)
            {
                foreach(var p in saida.Lista_produtos)
                {
                    Result = DAO.AtualizaEstoque(Autenticacao.GetCodUsuario(), Autenticacao.GetCodFilial(), saida.Id, p.CodProduto, saida.CFOP, p.Qtde);
                    if (Result == null)
                        return false;
                    if (Result.Rows.Count <= 0)
                        return false;
                    if (Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        return false;
                }
            }

            return true;
        }

        public bool FechaVendasTodas()
        {
            MovSaidasDAO DAO = new MovSaidasDAO();
            DataTable Result = new DataTable();
          
                    Result = DAO.FechaTodasVendas();
                    if (Result == null)
                        return false;
    
            return true;
        }


        private List<Saida> DataToEntitySaidas(DataTable data)
        {
            List<Saida> SAIDAS = new List<Saida>();

            foreach (DataRow linha in data.Rows)
            {
                Saida saida = new Saida();

                saida.Id = linha.ItemArray[0].ToString();
                saida.NumNota = linha.ItemArray[1].ToString();
                saida.Comanda = linha.ItemArray[2].ToString();
                saida.Mesa = linha.ItemArray[3].ToString();
                saida.Painel = linha.ItemArray[4].ToString();
                try { saida.Filial = (int)linha.ItemArray[5]; } catch { }
                try { saida.Data = (DateTime)linha.ItemArray[6]; } catch { }
                saida.CFOP = linha.ItemArray[7].ToString();
                try { saida.Caixa = (int)linha.ItemArray[8]; } catch { }
                saida.Cliente = linha.ItemArray[9].ToString();
                saida.CPF = linha.ItemArray[10].ToString();
                saida.Vendedor = linha.ItemArray[11].ToString();
                saida.Observacoes = linha.ItemArray[12].ToString();
                try { saida.Produtos = (decimal)linha.ItemArray[13]; } catch { }
                try { saida.Desconto = (decimal)linha.ItemArray[14];} catch { }
                try { saida.ParaEntrega = (int)linha.ItemArray[15]; } catch { }
                try { saida.Frete = (decimal)linha.ItemArray[16]; } catch { }
                try { saida.Total = (decimal)linha.ItemArray[17]; } catch { }
                try { saida.Efetivada_estoque = (int)linha.ItemArray[18]; } catch { }
                try { saida.Efetivada_Financ = (int)linha.ItemArray[19]; } catch { }
                try { saida.Nota_Impressa = (int)linha.ItemArray[20]; } catch { }
                try { saida.Nota_cancelada = (int)linha.ItemArray[21]; } catch { }
                try { saida.Tiket_Impresso = (int)linha.ItemArray[22]; } catch { }
                try { saida.Recebe_Dinheiro = (decimal)linha.ItemArray[23]; } catch { }
                try { saida.Recebe_Credito_Cliente = (decimal)linha.ItemArray[24]; } catch { }
                try { saida.Recebe_Cartao_Debito = (decimal)linha.ItemArray[25]; } catch { }
                try { saida.Recebe_cartao_Credito = (decimal)linha.ItemArray[26]; } catch { }
                try { saida.Recebe_Cartao_Convenio = (decimal)linha.ItemArray[27]; } catch { }
                try { saida.Recebe_Total = (decimal)linha.ItemArray[28]; } catch { }
                saida.Endereco_Entrega = linha.ItemArray[29].ToString();
                saida.Complemento_Entrega = linha.ItemArray[30].ToString();
                saida.Cidade_Entrega = linha.ItemArray[31].ToString();
                saida.Estado_Entrega = linha.ItemArray[32].ToString();
                saida.Bairro_Entrega = linha.ItemArray[33].ToString();
                saida.CEP_Entrega = linha.ItemArray[34].ToString();
                saida.Transportadora = linha.ItemArray[35].ToString();
                try { saida.Peso = (decimal)linha.ItemArray[36]; } catch { }
                try { saida.Volumes = (int)linha.ItemArray[37]; } catch { }
                try { saida.Data_Nota_Impressa = (DateTime)linha.ItemArray[38];} catch { }
                saida.Motivo_cancelamento = linha.ItemArray[39].ToString();
                saida.Usuario_Cancelamento = linha.ItemArray[40].ToString();
                saida.NumRua_Entrega = linha.ItemArray[41].ToString();
                saida.NomeCliente = linha.ItemArray[42].ToString();
                saida.NomeTransportadora = linha.ItemArray[43].ToString();
                saida.NomeVendedor = linha.ItemArray[44].ToString();
                try { saida.Troco_Entrega = (decimal)linha.ItemArray[45]; } catch { }
                saida.Pagamento_Entrega = linha.ItemArray[46].ToString();

                SAIDAS.Add(saida);
            }

            return SAIDAS;
        }

        private List<Saida_Produtos> DataToEntitySaida_Produto(DataTable data)
        {
            List<Saida_Produtos> PRODUTOS = new List<Saida_Produtos>();
            foreach (DataRow linha in data.Rows)
            {
                Saida_Produtos produto = new Saida_Produtos();

                try { produto.ID = (int)linha.ItemArray[0]; } catch { }
                produto.ID_Saida = linha.ItemArray[1].ToString();
                try { produto.Linha = (int)linha.ItemArray[2]; } catch { }
                produto.CodProduto = linha.ItemArray[3].ToString();
                produto.NomeProduto = linha.ItemArray[4].ToString();
                try { produto.Tabela_Preco = (int)linha.ItemArray[5]; } catch { }
                try { produto.Qtde = (decimal)linha.ItemArray[6]; } catch { }
                try { produto.Preco_Unit = (decimal)linha.ItemArray[7]; } catch { }
                try { produto.Preco_Total = (decimal)linha.ItemArray[8]; } catch { }
                try { produto.Desconto = (decimal)linha.ItemArray[9]; } catch { }
                try { produto.Preco_Final = (decimal)linha.ItemArray[10]; } catch { }

                PRODUTOS.Add(produto);
            }

            return PRODUTOS;
        }

        private Produto DataToEntityProduto(DataTable data)
        {
            Produto pro = new Produto();
            try { pro.Ativo = (int)data.Rows[0].ItemArray[0]; }
            catch (Exception) { }
            pro.Codigo = data.Rows[0].ItemArray[1].ToString();
            try { pro.Fracionado = (int)data.Rows[0].ItemArray[2]; }
            catch (Exception) { }
            try { pro.Tipo = (int)data.Rows[0].ItemArray[3]; }
            catch (Exception) { }
            pro.Nome = data.Rows[0].ItemArray[4].ToString();
            try { pro.Estoque = (int)data.Rows[0].ItemArray[5]; }
            catch (Exception) { }
            pro.Unidade_Venda = data.Rows[0].ItemArray[6].ToString();
            pro.Codigo_Fornecedor = data.Rows[0].ItemArray[7].ToString();
            pro.Fabricante = data.Rows[0].ItemArray[8].ToString();
            pro.Foto = data.Rows[0].ItemArray[9].ToString();
            pro.Peso = data.Rows[0].ItemArray[10].ToString();
            pro.Obs = data.Rows[0].ItemArray[11].ToString();
            pro.Preco1 = data.Rows[0].ItemArray[12].ToString();
            pro.Preco2 = data.Rows[0].ItemArray[13].ToString();
            pro.Preco3 = data.Rows[0].ItemArray[14].ToString();
            pro.Custo = data.Rows[0].ItemArray[15].ToString();

            return pro;
        }
    }
}
