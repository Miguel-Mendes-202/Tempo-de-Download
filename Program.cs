﻿double TamanhoBytes, VelocidadeMbps, TempoMin;


Console.WriteLine("--- Tempo de Download ---\n");

Console.Write("Tamanho do arquivo em MB....: ");
TamanhoBytes = Convert.ToDouble(Console.ReadLine());

Console.Write("Velocidade da conexão em Mbps...: ");

VelocidadeMbps = Convert.ToDouble(Console.ReadLine());

TempoMin = TamanhoBytes * 8 / VelocidadeMbps / 60;

Console.WriteLine($"\nTempo estimado de download: {TempoMin:N1} minutos");
