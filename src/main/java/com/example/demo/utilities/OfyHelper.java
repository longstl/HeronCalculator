package com.example.demo.utilities;

import com.example.demo.entity.Member;
import com.example.demo.entity.Triangle;
import com.example.demo.entity.User;
import com.googlecode.objectify.ObjectifyService;

import javax.servlet.ServletContextEvent;
import javax.servlet.ServletContextListener;

public class OfyHelper implements ServletContextListener {
    @Override
    public void contextInitialized(ServletContextEvent servletContextEvent) {
        // This will be invoked as part of a warmup request, or the first user request if no warmup
        ObjectifyService.register(Member.class);
        ObjectifyService.register(User.class);
        ObjectifyService.register(Triangle.class);
    }

    @Override
    public void contextDestroyed(ServletContextEvent servletContextEvent) {
        // App Engine does not currently invoke this method.
    }
}
