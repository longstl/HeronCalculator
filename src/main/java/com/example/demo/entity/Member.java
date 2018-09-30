package com.example.demo.entity;

import com.googlecode.objectify.annotation.Entity;
import com.googlecode.objectify.annotation.Id;
import com.googlecode.objectify.annotation.Index;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import java.util.Date;

@Entity
public class Member {
    @Id
    private long id;
    @Index
    @NotNull
    @Size(min = 5, max = 15, message = "Username should have atleast 5 character and maximum 15 character ")
    private String username;
    @Index
    @NotNull
    private String password;
    @Index
    @NotNull
    private String salt;
    @Index
    @NotNull
    @Size(min = 8, max = 15, message = "Username should have atleast 8 character and maximum 15 character ")
    private String phone;
    @Index
    @NotNull
    @Email
    private String email;
    @Index
    @NotNull
    private String avatar;
    private Date createAt;
    private Date updateAt;

    public Member() {
    }

    public Member(long id, @NotNull @Size(min = 5, max = 15, message = "Username should have atleast 5 character and maximum 15 character ") String username, @NotNull String password, @NotNull String salt, @NotNull @Size(min = 8, max = 15, message = "Username should have atleast 8 character and maximum 15 character ") String phone, @NotNull @Email String email, @NotNull String avatar, Date createAt, Date updateAt) {
        this.id = id;
        this.username = username;
        this.password = password;
        this.salt = salt;
        this.phone = phone;
        this.email = email;
        this.avatar = avatar;
        this.createAt = createAt;
        this.updateAt = updateAt;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getSalt() {
        return salt;
    }

    public void setSalt(String salt) {
        this.salt = salt;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getAvatar() {
        return avatar;
    }

    public void setAvatar(String avatar) {
        this.avatar = avatar;
    }

    public Date getCreateAt() {
        return createAt;
    }

    public void setCreateAt(Date createAt) {
        this.createAt = createAt;
    }

    public Date getUpdateAt() {
        return updateAt;
    }

    public void setUpdateAt(Date updateAt) {
        this.updateAt = updateAt;
    }
}
