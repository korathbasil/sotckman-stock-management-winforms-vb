Imports MySql.Data.MySqlClient

Module DbHelper
    Sub CreateTables()
        Dim UsersTableSchema = "create table if not exists users (id int not null auto_increment primary key, name varchar(25) not null, username varchar(25) not null, password varchar(20) not null, is_manager bool not null )"
        Dim ShareIssuesTableSchema = "create table if not exists share_issues (id int not null auto_increment primary key, issued_date datetime default now(), issued_quantity int not null, unsold_quantity int not null, price int)"
        Dim ShareHoldersTableSchema = "create table if not exists share_holders (id int not null auto_increment primary key, name varchar(40) not null, age int not null, gender varchar(6) not null, phone varchar(10) not null, aadhaar varchar(12) , addr1 varchar(20) not null, addr2 varchar(20), addr3 varchar(20), pin varchar(6) not null)"
        Dim ShareHolderSharesTableSchema = "create table if not exists share_holder_shares (id int not null auto_increment primary key, quantity int not null, share_holder_id int not null, share_issue_id int not null)"
        Try
            Form1.DbConnection.Open()
            Dim cmd = New MySqlCommand(UsersTableSchema, Form1.DbConnection)
            Dim cmd2 = New MySqlCommand(ShareIssuesTableSchema, Form1.DbConnection)
            Dim cmd3 = New MySqlCommand(ShareHoldersTableSchema, Form1.DbConnection)
            Dim cmd4 = New MySqlCommand(ShareHolderSharesTableSchema, Form1.DbConnection)
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            cmd4.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
            Form1.DbConnection.Dispose()
        End Try
    End Sub
End Module
