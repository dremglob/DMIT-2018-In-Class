﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageSpecialEvents.aspx.cs" Inherits="Admin_ManageSpecialEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="row col-md-12">
        <h1>Manage Special Events
            <span class="glyphicon glyphicon-cutlery"></span>
        </h1>
    

    <!-- ObjectDataSource control to do the underlying communication with my BLL and my ListView control-->
    <asp:ObjectDataSource ID="SpecialEventsDataSource" runat="server" TypeName="eRestaurant.Framework.BLL.RestaurantAdminController" SelectMethod="ListAllSpecialEvents" DataObjectTypeName="eRestaurant.Framework.Entities.SpecialEvent">
    </asp:ObjectDataSource>

    <%--<asp:GridView ID="SpecialEventsGridView" runat="server" DataSourceID="SpecialEventsDataSource"></asp:GridView>--%>
        <asp:ListView ID="SpecialEventListView" runat="server" DataSourceID="SpecialEventsDataSource">
            <LayoutTemplate>
                <fieldset runat="server" id="itemPlaceholderContainer">
                    <div runat="server" id="itemPlaceholder" />
                </fieldset>
            </LayoutTemplate>

            <ItemTemplate>
                <div>
                    <asp:LinkButton runat="server" CommandName="Edit" ID="EditButton">Edit<span class="glyphicon glyphicon-pencil"></span></asp:LinkButton>
                    &nbsp;&nbsp;
                    <asp:LinkButton runat="server" CommandName="Delete" ID="DeleteButton">Delete<span class="glyphicon glyphicon-trash"></span></asp:LinkButton>
                    &nbsp;
                    <asp:CheckBox Checked='<%# Eval("Active") %>' runat="server" ID="ActiveCheckBox" Enabled="false" Text="Active" />
                    &mdash;

                    <asp:Label runat="server" ID="Label1" AssociatedControlID="EventCodeData" CssClass="control-label">Event Code</asp:Label>
                    <asp:Label ID="EventCodeData" runat="server" Text='<%# Eval("EventCode") %>' />
                    &mdash;

                    <asp:Label runat="server" ID="Label2" AssociatedControlID="DescriptionData" CssClass="control-label">Description</asp:Label>
                    <asp:Label ID="DescriptionData" runat="server" Text ='<%# Eval("Description") %>' />
                </div>
            </ItemTemplate>
        </asp:ListView>

    </div>
</asp:Content>

