package aplicacao;
import java.util.Scanner;
import entidades.Produto;

public class Programa {
	public static void main(String[] args) {
		//Criar vari�veis e vetor
		Scanner ler = new Scanner(System.in);
		double sum = 0.0;
		int n = ler.nextInt();
		Produto[] vector = new Produto[n];
		
		//Percorrer, preencher e somar vetor
		for (int i = 0; i < vector.length; i++) {
			ler.nextLine();
			String nome = ler.nextLine();
			double preco = ler.nextDouble();
			vector[i] = new Produto(nome, preco);
			sum += vector[i].getPreco();
		}
		
		//Exibir a m�dia
		double avg = sum / vector.length;
		System.out.printf("Pre�o m�dio = %.2f%n", avg);
		ler.close();
	}
}