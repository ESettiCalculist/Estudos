import java.io.ObjectInputStream.GetField;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.net.http.HttpResponse.BodyHandler;
import java.net.http.HttpResponse.BodyHandlers;

public class App {
    public static void main(String[] args) throws Exception {
        String url = "https://pokeapi.co/api/v2/pokemon/ditto";
        HttpClient cliente = HttpClient.newHttpClient();
        HttpRequest requisicao = HttpRequest.newBuilder(URI.create(url)).GET().build();
    HttpResponse < String > resposta = cliente.send(requisicao, BodyHandlers.ofString());
        String json = resposta.body();
    System.out.println(json);

}
}