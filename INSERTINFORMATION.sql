﻿INSERT INTO tblContasReceberOrigem(IDContasReceberOrigem,Descricao)VALUES(2,'AUTOMÁTICO')
INSERT INTO tblContasReceberOrigem(IDContasReceberOrigem,Descricao)VALUES(1,'MANUAL')
INSERT INTO tblContasReceberSituacao (IDSituacao, Descricao)VALUES(1,'ABERTA')
INSERT INTO tblContasReceberSituacao (IDSituacao, Descricao)VALUES(2,'PAGA')
INSERT INTO tblContasReceberSituacao (IDSituacao, Descricao)VALUES(3,'EXCLUÍDA')
INSERT INTO tblOperacao(Descricao)VALUES('VENDA')
INSERT INTO tblOperacao(Descricao)VALUES('ORÇAMENTO')
INSERT INTO tblSituacao(Descricao)VALUES('EXCLUÍDO')
INSERT INTO tblSituacao(Descricao)VALUES('ABERTO')
INSERT INTO tblSituacao(Descricao)VALUES('FINALIZADO')
INSERT INTO tblOperacaoSituacao(IDOperacao,IDSituacao)VALUES(1,1)
INSERT INTO tblOperacaoSituacao(IDOperacao,IDSituacao)VALUES(1,2)
INSERT INTO tblOperacaoSituacao(IDOperacao,IDSituacao)VALUES(1,3)
INSERT INTO tblOperacaoSituacao(IDOperacao,IDSituacao)VALUES(2,1)
INSERT INTO tblOperacaoSituacao(IDOperacao,IDSituacao)VALUES(2,2)
INSERT INTO tblOperacaoSituacao(IDOperacao,IDSituacao)VALUES(2,3)
INSERT INTO tblPedidoTipo(IDPedidoTipo,DescricaoPedidoTipo)VALUES(1,'VENDA')
INSERT INTO tblPedidoTipo(IDPedidoTipo,DescricaoPedidoTipo)VALUES(2,'ORÇAMENTO')