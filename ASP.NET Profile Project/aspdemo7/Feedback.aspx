<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Feedback.aspx.cs" Inherits="aspdemo7.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- ======= Contact Section ======= 
    <div id="contact" class="paddsection">
      <div class="container">
        <div class="contact-block1">
          <div class="row">

            <div class="col-lg-6">
              <div class="contact-contact">

                <h2 class="mb-30">GET IN TOUCH</h2>

                <ul class="contact-details">
                  <li><span>At.Khairi (Panjabraw), Post Kothulana </span></li>
                  <li><span>Ta. Saoner Dis. Nagpur 441101</span></li>
                  <li><span>+91 8329627753</span></li>
                  <li><span>shribhoyar269@gmail.com</span></li>
                </ul>

              </div>
            </div>
        -->
         <br />
          <br />
        <div id="contact" class="paddsection">
      <div class="container">
        <div class="contact-block1">
          <div class="row">
            <div class="col-md-6 mx-auto">
              <form action="forms/contact.php" method="post" role="form" class="php-email-form">
                <div class="row gy-3">

                  <div class="col-lg-6">
                    <div class="form-group contact-block1">
                   
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                                      <asp:TextBox ID="nametxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="nametxt" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"  runat="server" ErrorMessage="Please Enter Name"></asp:RequiredFieldValidator>
                            </div>
                  </div>

                  <div class="col-lg-6">
                    <div class="form-group">
                    
                        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                                      <asp:TextBox ID="Laname"  CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="Laname" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Please Enter Last Name"></asp:RequiredFieldValidator>
                               </div>
                  </div>

                  <div class="col-lg-12">
                    <div class="form-group">
                      
                            <asp:Label ID="Label3" runat="server" Text="Label">Email</asp:Label>
                                <asp:TextBox ID="emailtxt"  CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3"  ControlToValidate="emailtxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true"  runat="server" ErrorMessage="Enter Your Mail"></asp:RequiredFieldValidator>

                    </div>
                  </div>

                  <div class="col-lg-12">
                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Comment"></asp:Label>
                                  <asp:TextBox ID="feedbtxt"  TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="feedbtxt" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Please Fill the Feedback"></asp:RequiredFieldValidator>
                         </div>
                  </div>

                  <div class="col-lg-12">
                    <div class="loading">Loading</div>
                    <div class="error-message"></div>
                    <div class="sent-message">Your message has been sent. Thank you!</div>
                  </div>

                  <div class="mt-0">
               

                <asp:Button ID="sbmbtn" CssClass="btn btn-defeault" runat="server" Text="Sumbit" Width="552px" OnClick="sbmbtn_Click" />
                  

                  </div>

                </div>
              </form>
            </div>
          </div>
  </div>
      </div>
    </div> 
          
          <!-- End Contact Section -->





                       </asp:Content>
