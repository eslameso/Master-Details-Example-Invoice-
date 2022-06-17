//adding new row to the body
const addRow = function (i) {
    var htmlElenent = `<tr>
                    <td><input asp-for="@Model.Details[${i}].ItemName" class="form-control"/></td>
                    <td><input asp-for="@Model.Details[${i}].Price" class="form-control" /></td>
                    <td><input asp-for="@Model.Details[${i}].Quantity" class="form-control" /></td>
                    <td><input asp-for="@Model.Details[${i}].Discount" class="form-control" /></td>
                    <td><input asp-for="@Model.Details[${i}].Total" class="form-control" /></td>
                    <td>
                        <button type="button" class="btn btn-danger btn-circle btn-sm deleteBtn">X</button>
                    </td>
                </tr>`
    return htmlElenent;
}