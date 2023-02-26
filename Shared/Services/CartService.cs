using LibreriaDCEA.Shared.Models;

namespace LibreriaDCEA.Shared.Services;

public class CartService {
    public List<Book> SelectedItems { get; set; } = new();

    public void AddToCart(int id) {
        var book = BookListService.Books.First(i => i.Id == id);
        if (SelectedItems.Contains(book) is false) {
            SelectedItems.Add(book);
        }
    }
}