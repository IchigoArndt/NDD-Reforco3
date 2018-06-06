CREATE TABLE [dbo].[TBAlocacao]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [IdSala] INT NOT NULL, 
    [IdFuncionario] INT NOT NULL, 
    [DataAlocacao] DATETIME NOT NULL, 
    CONSTRAINT [FK_TBAlocacao_TBSala] FOREIGN KEY ([IdSala]) REFERENCES [TBSala]([Id]) on delete cascade, 
    CONSTRAINT [FK_TBAlocacao_TBFuncionario] FOREIGN KEY ([IdFuncionario]) REFERENCES [TBFuncionario]([Id]) on delete cascade
)
