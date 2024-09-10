-- Faça uma busca utilizando comando SQL que traga o código, 
--a razão social e o(s) telefone(s) de todos os clientes do estado de São Paulo (código “SP”);

select *  from Cliente c inner join Telefone t on c.Id = t.IdCliente
                         inner join Estado e on e.ID = c.IdEstado
                         where e.Sigla = 'SP'