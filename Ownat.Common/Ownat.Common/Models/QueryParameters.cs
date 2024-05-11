namespace Ownat.Common.Models;

/// <summary>
/// Represents the parameters for a query.
/// </summary>
/// <remarks>
/// This class is used to handle pagination in queries. It includes properties for the page number and the size of the page.
/// The size is limited to a maximum of 100 items per page, with a default of 50 items per page.
/// </remarks>
public class QueryParameters
{
    const int _maxSize = 100;
    private int _size = 50;

    /// <summary>
    /// Gets or sets the page number for the query.
    /// </summary>
    /// <value>The page number.</value>
    public int Page { get; set; } = 1;

    /// <summary>
    /// Gets or sets the size of the page for the query.
    /// </summary>
    /// <value>The size of the page.</value>
    /// <remarks>
    /// The size is limited to a maximum of 100 items. If a larger size is set, it will be reduced to 100.
    /// </remarks>
    public int Size
    {
        get { return this._size; }

        set => this._size = Math.Min(_maxSize, value);
    }
}