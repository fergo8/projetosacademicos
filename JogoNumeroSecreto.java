import java.util.Scanner;
import java.util.Random;

class JogoNumeroSecreto {
	public static void main(String[] args) {
		// variavel scanner
		Scanner ler = new Scanner(System.in);

		// outras variaveis
		int opcao = 0;

		// introducao do jogo
		System.out.println("\n\n+-------------------------------+");
		System.out.println("|    Jogo do Numero Secreto     |");
		System.out.println("+-------------------------------+\n");

		System.out.println("- Criado por: Jefferson Gomes\n- Data: 23-10-2017\n\n\n");

		while (opcao != 3) {
			System.out.println("Digite uma das opcoes abaixo:\n\n1. Tutorial\n2. Comecar jogo\n3. Sair");
			opcao = ler.nextInt(); // insercao de dado

			switch(opcao) {
				case 1:
					tutorial(); // opcao Tutorial
					break;
				case 2:
					comecar(); // opcao Comecar jogo
					break;
				case 3:
					sair(); // opcao Sair
					break;
				default:
					invalido(); // numero invalido
					break;
			} // fim switch(opcao)
		} // fim laco while
	} // fim metodo principal

	public static void tutorial() {
		System.out.println("\n\n=========== Tutorial ===========\n");
		System.out.println("- Ao comecar o jogo, o sistema sorteia um numero");
		System.out.println("   aleatorio entre 0 e 100. Este numero eh secreto.");
		System.out.println("- O jogador tem direito a 10 tentativas para acertar");
		System.out.println("   qual eh o numero secreto.");
		System.out.println("- Caso o jogador erre, o sistema mostra um alerta");
		System.out.println("   indicando se o numero foi maior ou menor que o sorteado.");
		System.out.println("\n=================================\n\n");
	} // fim metodo tutorial

	public static void comecar() {
		// variavel randomica e variavel scanner
		Random ran = new Random();
		Scanner ler = new Scanner(System.in);

		// outras variaveis
		int secreto = 0;
		int tentativa = 10;
		int escolha = 0;

		System.out.println("\n\nSorteando numero secreto.");
		System.out.println("    [XX________] 20%\n    [XXXXXX____] 60%\n    [XXXXXXXXXX] 100%\n");

		secreto = ran.nextInt(101); // sorteio numero randomico

		while (tentativa > 0) {
			System.out.println("Digite um numero de 0 a 100:");
			escolha = ler.nextInt(); // entrada de dado

			if (escolha == secreto) {
				System.out.println("\nVoce descobriu o numero secreto!\nParabens!");
				tentativa = 0;
			}
			else if (escolha > 100){
				System.out.println("\nNumero invalido.\nPor favor, tente um numero de 0 a 100.");
			}
			else if (escolha < secreto) {
				System.out.println("\nNumero digitado eh MENOR que o numero secreto.");
				tentativa = tentativa - 1;
				System.out.println("    [tentativas restantes: "+tentativa+"]");
			}
			else if (escolha > secreto) {
				System.out.println("\nNumero digitado eh MAIOR que o numero secreto.");
				tentativa = tentativa - 1;
				System.out.println("    [tentativas restantes: "+tentativa+"]");
			}
		} // fim laco while(tentativa > 0)

		System.out.println("As tentativas acabaram.");
		System.out.println("\n=================================\n\n");
	} // fim metodo comecar

	public static void sair() {
		System.out.println("\n\nJogo sendo encerrado.\nObrigado por jogar!");
		System.out.println("\n=================================\n\n");
	} // fim metodo sair

	public static void invalido() {
		System.out.println("\nOpcao invalida.\nPor favor, escolha apenas uma das apresentadas.");
		System.out.println("\n=================================\n\n");
	} // fim metodo invalido
} // fim programa