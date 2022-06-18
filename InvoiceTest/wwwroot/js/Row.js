//adding new row to the body
const addRow = function (i) {
    var htmlElenent = `<tr>
                    <td><input asp-for="@Model.Details[${i}].ItemName" class="form-control ItemName"/></td>
                    <td><input type="number" asp-for="@Model.Details[${i}].Price" class="form-control Price" /></td>
                    <td><input type="number" asp-for="@Model.Details[${i}].Quantity" class="form-control Quantity" /></td>
                    <td><input type="number" asp-for="@Model.Details[${i}].Discount" class="form-control Discount" placeHolder="                           %" /></td>
                    <td><input type="number" asp-for="@Model.Details[${i}].Total" class="form-control Total" disabled /></td>
                    <td>
                        <button type="button" class="btn btn-danger btn-circle btn-sm deleteBtn">X</button>
                    </td>
                </tr>`
    return htmlElenent;
}