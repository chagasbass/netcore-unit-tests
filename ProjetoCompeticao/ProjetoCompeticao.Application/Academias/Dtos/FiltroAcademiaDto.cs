﻿namespace ProjetoCompeticao.Application.Academias.Dtos
{
    public class FiltroAcademiaDto
    {
        public int Pagina { get; set; } = 1;
        public int TamanhoPagina { get; set; } = 10;

        public FiltroAcademiaDto() { }

    }
}
