function RegisterValue(id, string)
{
    document.querySelector("#Type").value = string;
    document.querySelector("#ItemID").value = id;
    document.querySelector("form>button").click();
}