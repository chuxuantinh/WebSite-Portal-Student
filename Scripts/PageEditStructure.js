function CallWebMethodSuccess(results, context, methodName) {
    switch (methodName) {
        case "PanelStyleGet":
            {
                PanelStyleGetCallback(results, context, methodName);
            }
            break;
        case "PanelStyleUpdate":
            {
                PanelStyleUpdateCallback(results, context, methodName);
            }
            break;
        case "PanelRemove":
            {
                PanelRemoveCallback(results, context, methodName);
            }
            break;
        case "PortletInstanceAdd":
            {
                PortletInstanceAddCallback(results, context, methodName);
            }
            break;
        case "PortletRemove":
            {
                PortletRemoveCallback(results, context, methodName);
            }
            break;
        case "PortletEditCSSGet":
            {
                PortletEditCSSGetCallback(results, context, methodName);
            }
            break;
        case "PortletEditCSSUpdate":
            {
                PortletEditCSSUpdateCallback(results, context, methodName);
            }
            break;
        case "PortletInstanceCollectionGet":
            {
                LoadPortletReferenceCallback(results, context, methodName);
            }
            break;
        case "PortletInstanceReferenceAdd":
            {
                PortletInstanceReferenceAddCallback(results, context, methodName);
            }
            break;
    }
}

function PanelRemoveCallback(results, context, methodName) {
    PostBack();
}
function PanelStyleGet(idPanel) {
    PageMethods.set_defaultUserContext(idPanel);
    PageMethods.PanelStyleGet(idPanel, CallWebMethodSuccess, CallWebMethodFailed);
}
function PanelStyleGetCallback(results, context, methodName) {
    var style = window.showModalDialog("/Controls/CSSEditor.aspx", results, "dialogHeight: 500px; dialogWidth: 700px;");
    var panelId = context;
    if (style != undefined) {
        PanelStyleUpdate(panelId, style);
    }
}
function PanelStyleUpdate(idPanel, style) {
    PageMethods.set_defaultUserContext(style);
    PageMethods.PanelStyleUpdate(idPanel, style, CallWebMethodSuccess, CallWebMethodFailed);
}
function PanelStyleUpdateCallback(results, context, methodName) {
    var panel = document.getElementById("pn" + results + "Display");
    panel.style.cssText = "border-width:1px;border-style:Solid;" + context;
    document.getElementById("pn" + results + "Title").style.width = panel.style.width;
}

function PortletInstanceAddCallback(results, context, methodName) {
    PostBack();
}

function PortletRemoveCallback(results, context, methodName) {
    PostBack();
}
function PortletEditCSS(idPortlet) {
    PortletEditCSSGet(idPortlet);
}
function PortletEditCSSGet(idPortlet) {
    PageMethods.set_defaultUserContext(idPortlet);
    PageMethods.PortletEditCSSGet(idPortlet, CallWebMethodSuccess, CallWebMethodFailed);
}
function PortletEditCSSGetCallback(results, context, methodName) {
    var style = window.showModalDialog("/Controls/CSSEditor.aspx", results, "dialogHeight: 500px; dialogWidth: 700px;");
    if (style == null)
        return;
    var id = context;
    PortletEditCSSUpdate(id, style);
}
function PortletEditCSSUpdate(idPortlet, css) {
    PageMethods.set_defaultUserContext({ Id: idPortlet, Style: css });
    PageMethods.PortletEditCSSUpdate(idPortlet, css, CallWebMethodSuccess, CallWebMethodFailed);
}
function PortletEditCSSUpdateCallback(results, context, methodName) {
    document.getElementById("portlet_" + context.Id).style.cssText = context.Style;
}
function pageLoad() {
    LoadSortables();
}
function LoadSortables() {
    if (document.getElementById("pnTopDisplay"))
        Sortable.create("pnTopDisplay", { tag: 'div', handle: 'TitlePortlet', dropOnEmpty: true, containment: ["pnTopDisplay", "pnLeftDisplay", "pnCenterDisplay", "pnRightDisplay", "pnBottomDisplay"], onUpdate: OnChange });
    if (document.getElementById("pnLeftDisplay"))
        Sortable.create("pnLeftDisplay", { tag: 'div', handle: 'TitlePortlet', dropOnEmpty: true, containment: ["pnLeftDisplay", "pnTopDisplay", "pnCenterDisplay", "pnRightDisplay", "pnBottomDisplay"], onUpdate: OnChange });
    if (document.getElementById("pnCenterDisplay"))
        Sortable.create("pnCenterDisplay", { tag: 'div', handle: 'TitlePortlet', dropOnEmpty: true, containment: ["pnCenterDisplay", "pnLeftDisplay", "pnTopDisplay", "pnRightDisplay", "pnBottomDisplay"], onUpdate: OnChange });
    if (document.getElementById("pnRightDisplay"))
        Sortable.create("pnRightDisplay", { tag: 'div', handle: 'TitlePortlet', dropOnEmpty: true, containment: ["pnRightDisplay", "pnLeftDisplay", "pnCenterDisplay", "pnTopDisplay", "pnBottomDisplay"], onUpdate: OnChange });
    if (document.getElementById("pnBottomDisplay"))
        Sortable.create("pnBottomDisplay", { tag: 'div', handle: 'TitlePortlet', dropOnEmpty: true, containment: ["pnBottomDisplay", "pnLeftDisplay", "pnCenterDisplay", "pnRightDisplay", "pnTopDisplay"], onUpdate: OnChange });

    strStatus = Serialize();
}
function Serialize() {
    var top = "";
    if ($("pnTopDisplay"))
        top = Sortable.serialize("pnTopDisplay", { name: "portlet" });
    var left = "";
    if ($("pnLeftDisplay"))
        left = Sortable.serialize("pnLeftDisplay", { name: "portlet" });
    var center = "";
    if ($("pnCenterDisplay"))
        center = Sortable.serialize("pnCenterDisplay", { name: "portlet" });
    var right = "";
    if ($("pnRightDisplay"))
        right = Sortable.serialize("pnRightDisplay", { name: "portlet" });
    var bottom = "";
    if ($("pnBottomDisplay"))
        bottom = Sortable.serialize("pnBottomDisplay", { name: "portlet" });
    var temp = top + "|" + left + "|" + center + "|" + right + "|" + bottom;
    return temp;
}
function ParsePosition(strListPosition) {
    var arrPanel = strListPosition.split("|");
    var messagePositions = "[";
    for (var i = 0; i < arrPanel.length; i++) {
        if (i != 0)
            messagePositions += ", ";
        var arrElement = arrPanel[i].split("&");
        messagePositions += "[";
        if (arrElement[0].length > 0)
            for (var j = 0; j < arrElement.length; j++) {
            if (j != 0)
                messagePositions += ", ";
            messagePositions += "\"" + arrElement[j].split("=")[1] + "\"";
        }
        messagePositions += "]";
    }
    messagePositions += "]";

    return messagePositions;
}
function OnChange() {
    var temp = Serialize();
    if (temp != strStatus) {
        OnUpdatePosition(temp);
        strStatus = temp;
    }
}
function OnUpdatePosition(strListNew) {
    var arrListOrg = Sys.Serialization.JavaScriptSerializer.deserialize(ParsePosition(strStatus));
    var arrListNew = Sys.Serialization.JavaScriptSerializer.deserialize(ParsePosition(strListNew));
    var i = 0;
    var index1 = 0;
    var index2 = 0;
    if (arrListOrg[0].length == arrListNew[0].length &&
                        arrListOrg[1].length == arrListNew[1].length &&
                        arrListOrg[2].length == arrListNew[2].length &&
                        arrListOrg[3].length == arrListNew[3].length &&
                        arrListOrg[4].length == arrListNew[4].length) {

        while ((index1 = CompareArray(arrListOrg[i], arrListNew[i++])) == -1);
        i = 0;
        while ((index2 = CompareArrayLast(arrListOrg[i], arrListNew[i++])) == -1);
        i--;
        var temp = arrListOrg[i][index1];
        for (var j = index1; j < index2; j++)
            arrListOrg[i][j] = arrListOrg[i][j + 1];
        arrListOrg[i][index2] = temp;
        if (CompareArray(arrListOrg[i], arrListNew[i]) == -1) {
            PageMethods.PortletChangePosition(i, index1, i, index2);
        }
        else {
            PageMethods.PortletChangePosition(i, index2, i, index1);
        }
    }
    else {
        var arrPanel = new Array();
        for (j = 0; j < arrListOrg.length; j++)
            if (arrListNew[j].length != arrListOrg[j].length)
            arrPanel[i++] = j;
        index1 = CompareArrayAsync(arrListOrg[arrPanel[0]], arrListNew[arrPanel[0]]);
        index2 = CompareArrayAsync(arrListOrg[arrPanel[1]], arrListNew[arrPanel[1]]);
        if (arrListOrg[arrPanel[0]].length > arrListNew[arrPanel[0]].length) {
            PageMethods.PortletChangePosition(arrPanel[0], index1, arrPanel[1], index2);
        }
        else {
            PageMethods.PortletChangePosition(arrPanel[1], index2, arrPanel[0], index1);
        }
    }
}

function CompareArrayAsync(arrSrc, arrDest) {
    var arrLarge = arrSrc.length > arrDest.length ? arrSrc : arrDest;
    var arrSmall = arrSrc.length > arrDest.length ? arrDest : arrSrc;
    for (var i = 0; i < arrLarge.length; i++)
        if (Search(arrSmall, arrLarge[i]) == -1)
        return i;
    return -1;
}
function CompareArray(arrSrc, arrDest) {
    for (var i = 0; i < arrSrc.length; i++)
        if (arrSrc[i] != arrDest[i])
        return i;
    return -1;
}
function Search(arrSrc, element) {
    for (var i = 0; i < arrSrc.length; i++)
        if (arrSrc[i] == element)
        return i;
    return -1;
}
function CompareArrayLast(arrSrc, arrDest) {
    for (var i = arrSrc.length - 1; i >= 0; i--)
        if (arrSrc[i] != arrDest[i])
        return i;
    return -1;
}
function LoadPortletReference(id) {
    PageMethods.PortletInstanceCollectionGet(id, CallWebMethodSuccess, CallWebMethodFailed);
}

function DropDownListBind(listNameValuePair, dropdownlistName) {
    var dropdownlist = document.getElementById(dropdownlistName);
    dropdownlist.innerHTML = "";

    for (var i = 0; i < listNameValuePair.length; i++) {
        var item = document.createElement("option");
        item.innerHTML = listNameValuePair[i].Name;
        item.value = listNameValuePair[i].Id;
        dropdownlist.appendChild(item);
    }
}
function PortletInstanceReferenceAddCallback(results, context, methodName) {
    PostBack();
}
function PortletEditData(id) {
    if (window.showModalDialog(String.format("PortletEdit.aspx?id={0}", id), null, "dialogHeight:600px; dialogWidth:800px"))
        PostBack();
}