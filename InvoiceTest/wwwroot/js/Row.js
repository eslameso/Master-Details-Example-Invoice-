//adding new row to the body
const addRow = function (i) {
    var htmlElenent = `<tr>
                    <td>
                    
                     <select asp-for="Details[${i}].ItemId" asp-items="@(new SelectList(Model.Items,"Id","Name"))" class="form-control ItemId" name="Details[${i}].ItemId">
                        <option>
 
                        </option>
                    </select>
                    </td>
                    <td><input type="number" asp-for="@Model.Details[${i}].Price" class="form-control Price" name="Details[${i}].Price"/></td>
                    <td><input type="number" asp-for="@Model.Details[${i}].Quantity" class="form-control Quantity" name="Details[${i}].Quantity"/></td>
                    <td><input type="number" asp-for="@Model.Details[${i}].Discount" class="form-control Discount" placeHolder="                           %" name="Details[${i}].Discount"/></td>
                    <td><input type="number" asp-for="@Model.Details[${i}].Total" class="form-control Total" disabled name="Details[${i}].Total"/></td>
                    <td>
                        <button type="button" class="btn btn-danger btn-circle btn-sm deleteBtn">X</button>
                    </td>
                </tr>`
    return htmlElenent;
}
   

//const addRow = function (i) {
//    var htmlElenent = `<tr>
//                        <td>
//                        @Html.EditorFor(m => m.Details[${i}].ItemName,new { htmlAttributes=new { @class= "form-control ItemName" } })
//                        </td>
//                        <td>
//                            @Html.EditorFor(m => m.Details[${i}].Price, new { htmlAttributes = new { @class = "form-control Price" } })

//                        </td>
//                        <td>
//                            @Html.EditorFor(m => m.Details[${i}].Quantity, new { htmlAttributes = new { @class = "form-control Quantity"} })

//                        </td>
//                        <td>
//                            @Html.EditorFor(m => m.Details[${i}].Discount, new { htmlAttributes = new { @class = "form-control Discount", @placeHolder = "                           %" } })

//                        </td>
//                        <td>
//                            @Html.EditorFor(m => m.Details[${i}].Total, new { htmlAttributes = new { @class = "form-control Total" } })

//                        </td>
//                        <td>
//                            <button type="button" class="btn btn-danger btn-circle btn-sm deleteBtn">X</button>
//                        </td>
//                    </tr>`
//    return htmlElenent;
//}