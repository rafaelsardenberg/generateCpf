/// <summary>
/// Generates a random cpf
/// </summary>
/// <param name="firstPartCpf">First six chars of cpf</param>
/// <returns></returns>
protected static string GenerateCpf(string firstPartCpf) {
			var soma = 0;
			var multiplicador1 = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			var multiplicador2 = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

			var rnd = new Random();
			var lastPartCpf = rnd.Next(100, 999).ToString();

			var semente = firstPartCpf + lastPartCpf;

			for (var i = 0; i < 9; i++)
				soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

			var resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			semente = semente + resto;
			soma = 0;

			for (var i = 0; i < 10; i++)
				soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

			resto = soma % 11;

			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			semente = semente + resto;
			return semente;
		}
