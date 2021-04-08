using BookTalk.Data;
using System.Collections.Generic;
using System.Linq;

public static class CustomerCart
{
    private static List<string> _cart = new List<string>();

    public static void AddToCart(string bookId)
    {
        _cart.Add(bookId);
    }

    public static void RemoveFromCart(string bookId)
    {
        _cart.Remove(bookId);
    }

    public static List<string> GetCart()
    {
        return _cart;
    }

    public static int GetCartCount()
    {
        return _cart.Count;
    }
}
